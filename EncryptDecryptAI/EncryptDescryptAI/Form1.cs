using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptDescryptAI
{
    public delegate void ApplyConfig(string json,AIModes mode);
    public partial class Form1 : Form
    {
        private ConfigReader _configReader;
        private DecryptAI _decryptAI;
        private EncryptAI _encryptAI;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            var fileBrowserDialog = new OpenFileDialog();
            var showResult = fileBrowserDialog.ShowDialog();
            if (showResult == DialogResult.OK)
            {
                txtBrowse.Text = fileBrowserDialog.FileName;
            }

            _configReader = new ConfigReader(txtBrowse.Text);
            txtDescrypted.Text = _configReader.Json;


            cmbSecurityKey.DataSource = _configReader.ItemConfigs.RetrievalOnlyKeyVal();
            cmbSecurityKey.DisplayMember = "Key";
            cmbSecurityKey.ValueMember = "Value";

            cmbSecurityKey.Enabled = true;
        }

        private void txtBrowse_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnBrowse_Click(sender, e);
        }

        private void cmbSecurityKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = cmbSecurityKey.SelectedItem as KeyVal;
            if (obj != null)
            {
                txtSecurityKey.Text = obj.Value;
            }
        }
        /// <summary>
        /// Giả mã nội dung được mã hóa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDescrypt_Click(object sender, EventArgs e)
        {
            // chuyển nội dung enscrypted thành decrypted.
            _decryptAI = new DecryptAI(txtSecurityKey.Text, _configReader.ItemConfigs);
            txtEncrypted.Text =  _decryptAI.Json;

            this.btnNodeConfigEncrypted.Enabled = true;
        }

        /// <summary>
        /// Mã hóa nội dung
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            _encryptAI = new EncryptAI(txtSecurityKey.Text, _decryptAI.ItemConfigsDescrypt);
            txtDescrypted.Text = _encryptAI.Json;
        }

        private void btnNodeConfigEncrypted_Click(object sender, EventArgs e)
        {
            
            var frmConf = new Form2(AIModes.DECRYPT, _decryptAI.ItemConfigsDescrypt);
            frmConf.ApplyConfigEvent += ApplyConfigAI;
            frmConf.ShowDialog();
        }

        private void ApplyConfigAI(string json, AIModes mode)
        {
            switch (mode)
            {
                case AIModes.DECRYPT:
                    _decryptAI.ApplyConfig(json);
                    // cập nhật lại json
                    txtEncrypted.Text = _decryptAI.Json;
                    // Cho phép chuyển nội dung config sang nội dung mã hóa
                    this.btnEncrypt.Enabled = true;
                    this.txtSecurityKey.Enabled = true;
                    break;
                case AIModes.ENDCRYPT:
                    _encryptAI.ApplyConfig(json);
                    break;
                default:
                    break;
            }
        }
    }
}
