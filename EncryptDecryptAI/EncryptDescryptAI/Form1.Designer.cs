namespace EncryptDescryptAI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBrowse = new System.Windows.Forms.Button();
            this.cmbSecurityKey = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSecurityKey = new System.Windows.Forms.TextBox();
            this.txtDescrypted = new FastColoredTextBoxNS.FastColoredTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtEncrypted = new FastColoredTextBoxNS.FastColoredTextBox();
            this.txtBrowse = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNodeConfigEncrypted = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDescrypt = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescrypted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEncrypted)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(721, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // cmbSecurityKey
            // 
            this.cmbSecurityKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSecurityKey.Enabled = false;
            this.cmbSecurityKey.FormattingEnabled = true;
            this.cmbSecurityKey.Location = new System.Drawing.Point(22, 59);
            this.cmbSecurityKey.Name = "cmbSecurityKey";
            this.cmbSecurityKey.Size = new System.Drawing.Size(471, 21);
            this.cmbSecurityKey.TabIndex = 1;
            this.cmbSecurityKey.SelectedIndexChanged += new System.EventHandler(this.cmbSecurityKey_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose security key";
            // 
            // txtSecurityKey
            // 
            this.txtSecurityKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSecurityKey.Enabled = false;
            this.txtSecurityKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecurityKey.ForeColor = System.Drawing.Color.DarkRed;
            this.txtSecurityKey.Location = new System.Drawing.Point(527, 59);
            this.txtSecurityKey.Name = "txtSecurityKey";
            this.txtSecurityKey.Size = new System.Drawing.Size(269, 20);
            this.txtSecurityKey.TabIndex = 2;
            // 
            // txtDescrypted
            // 
            this.txtDescrypted.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtDescrypted.AutoIndentCharsPatterns = "\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\n^\\s*(case|default)\\s*[^:]*(" +
    "?<range>:)\\s*(?<range>[^;]+);\n";
            this.txtDescrypted.AutoScrollMinSize = new System.Drawing.Size(155, 14);
            this.txtDescrypted.BackBrush = null;
            this.txtDescrypted.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txtDescrypted.CharHeight = 14;
            this.txtDescrypted.CharWidth = 8;
            this.txtDescrypted.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescrypted.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtDescrypted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescrypted.IsReplaceMode = false;
            this.txtDescrypted.Language = FastColoredTextBoxNS.Language.CSharp;
            this.txtDescrypted.LeftBracket = '(';
            this.txtDescrypted.LeftBracket2 = '{';
            this.txtDescrypted.Location = new System.Drawing.Point(0, 0);
            this.txtDescrypted.Name = "txtDescrypted";
            this.txtDescrypted.Paddings = new System.Windows.Forms.Padding(0);
            this.txtDescrypted.RightBracket = ')';
            this.txtDescrypted.RightBracket2 = '}';
            this.txtDescrypted.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtDescrypted.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtDescrypted.ServiceColors")));
            this.txtDescrypted.Size = new System.Drawing.Size(390, 287);
            this.txtDescrypted.TabIndex = 5;
            this.txtDescrypted.Text = "{\"name\":\"value\"}";
            this.txtDescrypted.Zoom = 100;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(2, 158);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtDescrypted);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtEncrypted);
            this.splitContainer1.Size = new System.Drawing.Size(799, 287);
            this.splitContainer1.SplitterDistance = 390;
            this.splitContainer1.TabIndex = 6;
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtEncrypted.AutoIndentCharsPatterns = "\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\n^\\s*(case|default)\\s*[^:]*(" +
    "?<range>:)\\s*(?<range>[^;]+);\n";
            this.txtEncrypted.AutoScrollMinSize = new System.Drawing.Size(155, 14);
            this.txtEncrypted.BackBrush = null;
            this.txtEncrypted.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txtEncrypted.CharHeight = 14;
            this.txtEncrypted.CharWidth = 8;
            this.txtEncrypted.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEncrypted.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtEncrypted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEncrypted.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtEncrypted.IsReplaceMode = false;
            this.txtEncrypted.Language = FastColoredTextBoxNS.Language.CSharp;
            this.txtEncrypted.LeftBracket = '(';
            this.txtEncrypted.LeftBracket2 = '{';
            this.txtEncrypted.Location = new System.Drawing.Point(0, 0);
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.Paddings = new System.Windows.Forms.Padding(0);
            this.txtEncrypted.RightBracket = ')';
            this.txtEncrypted.RightBracket2 = '}';
            this.txtEncrypted.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtEncrypted.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtEncrypted.ServiceColors")));
            this.txtEncrypted.Size = new System.Drawing.Size(405, 287);
            this.txtEncrypted.TabIndex = 5;
            this.txtEncrypted.Text = "{\"name\":\"value\"}";
            this.txtEncrypted.Zoom = 100;
            // 
            // txtBrowse
            // 
            this.txtBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBrowse.Location = new System.Drawing.Point(22, 13);
            this.txtBrowse.Name = "txtBrowse";
            this.txtBrowse.Size = new System.Drawing.Size(693, 20);
            this.txtBrowse.TabIndex = 0;
            this.txtBrowse.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtBrowse_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbSecurityKey);
            this.panel1.Controls.Add(this.txtSecurityKey);
            this.panel1.Controls.Add(this.txtBrowse);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 103);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Security Key";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnNodeConfigEncrypted);
            this.panel2.Controls.Add(this.btnEncrypt);
            this.panel2.Controls.Add(this.btnDescrypt);
            this.panel2.Location = new System.Drawing.Point(2, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 47);
            this.panel2.TabIndex = 7;
            // 
            // btnNodeConfigEncrypted
            // 
            this.btnNodeConfigEncrypted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNodeConfigEncrypted.Enabled = false;
            this.btnNodeConfigEncrypted.Location = new System.Drawing.Point(439, 7);
            this.btnNodeConfigEncrypted.Name = "btnNodeConfigEncrypted";
            this.btnNodeConfigEncrypted.Size = new System.Drawing.Size(108, 23);
            this.btnNodeConfigEncrypted.TabIndex = 4;
            this.btnNodeConfigEncrypted.Text = "Node Encrypted";
            this.toolTip1.SetToolTip(this.btnNodeConfigEncrypted, "Thay đổi nội dung của file config");
            this.btnNodeConfigEncrypted.UseVisualStyleBackColor = true;
            this.btnNodeConfigEncrypted.Click += new System.EventHandler(this.btnNodeConfigEncrypted_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.Location = new System.Drawing.Point(358, 7);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 5;
            this.btnEncrypt.Text = "<<Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDescrypt
            // 
            this.btnDescrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDescrypt.Location = new System.Drawing.Point(277, 7);
            this.btnDescrypt.Name = "btnDescrypt";
            this.btnDescrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDescrypt.TabIndex = 3;
            this.btnDescrypt.Text = "Descrypt>>";
            this.btnDescrypt.UseVisualStyleBackColor = true;
            this.btnDescrypt.Click += new System.EventHandler(this.btnDescrypt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "product of chaudt@saigonnewport";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.txtDescrypted)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEncrypted)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox cmbSecurityKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSecurityKey;
        private FastColoredTextBoxNS.FastColoredTextBox txtDescrypted;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtBrowse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private FastColoredTextBoxNS.FastColoredTextBox txtEncrypted;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNodeConfigEncrypted;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDescrypt;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
    }
}

