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
    public partial class Form2 : Form
    {
        public event ApplyConfig ApplyConfigEvent;
        private readonly AIModes _currentMode;
        private readonly IEnumerable<ItemConfig> _itemConfigs;
        public Form2(AIModes _mode, IEnumerable<ItemConfig> itemConfigs)
        {
            InitializeComponent();
            _currentMode = _mode;
            _itemConfigs = itemConfigs;

            ShowJson();
            ShowLegend();

        }
        private void ShowLegend()
        {
            var txtTypeCode = @"
/*
* Ta sử dụng enum TypeCode để đánh dấu kiểu dữ liệu của config:
* 1. TypeCode.Boolean (3): Kiểu dữ liệu boolean
* 2. TypeCode.Double (14): Kiểu dữ liệu double
* 3. TypeCode.Int32 (9): Kiểu dữ liệu int
* 4. TypeCode.String (18): Kiểu dữ liệu string
* 5. TypeCode.Byte (6): Đánh dấu mảng config vd:[404,202] hoặc []
* 5. TypeCode.SByte (5): Đánh dấu mảng item config,
vd: [
      {
        ""item1"":""val1"",
        ""item2"":""val2""
      },
      {
        ""item3"":""val3"",
        ""item4"":""val4""
      },
    ]
*/
";
            txtTypeCodeLegend.Text = txtTypeCode;


            var txtLengend = @"""Key"": ""<key>"",// Trường Key của config-trường key luôn là kiểu string
""Value"": <value>,//Giá trị của config, có thể là kiểu int, double, decimal, boolean.
//Ngoài ra, với 1 số config phức tạp, giá trị của config sẽ là 1 object hoặc arrayobject thì trường này sẽ
// không được sử dụng, mà sử dụng các trường phía dưới để thay thế thích hợp:
""ValueItems"": <object>,// Nếu trường hợp value của config là object
""ValueArrayItems"": <array-object>,// Nếu trường hợp value của config là array-objects
""ConfigValueType"": <config-value-type>,// NONE = 0,STRING=1,OBJECT=2,ARRAY=3
""TypeCode"": <type-code>,// xem thêm chú thích về TypeCode
""IsFlagDecrypt"": <is-flag-decrypt>//Đánh dấu object config này có được mã hóa hay không?";

            txtLegend.Text = txtLengend;
        }
        private void ShowJson()
        {
            txtConfigText.Text = Newtonsoft.Json.JsonConvert.SerializeObject(this._itemConfigs, Newtonsoft.Json.Formatting.Indented);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.txtConfigText.Enabled = !this.txtConfigText.Enabled;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (ApplyConfigEvent != null)
            {
                ApplyConfigEvent(txtConfigText.Text, _currentMode);
            }
            this.Close();
        }
    }
}
