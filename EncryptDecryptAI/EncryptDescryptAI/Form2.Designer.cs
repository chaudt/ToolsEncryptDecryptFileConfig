namespace EncryptDescryptAI
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtConfigText = new FastColoredTextBoxNS.FastColoredTextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTypeCodeLegend = new FastColoredTextBoxNS.FastColoredTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLegend = new FastColoredTextBoxNS.FastColoredTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfigText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTypeCodeLegend)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLegend)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtConfigText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 419);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnApply);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Location = new System.Drawing.Point(1, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 33);
            this.panel2.TabIndex = 0;
            // 
            // txtConfigText
            // 
            this.txtConfigText.AutoCompleteBracketsList = new char[] {
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
            this.txtConfigText.AutoScrollMinSize = new System.Drawing.Size(179, 14);
            this.txtConfigText.BackBrush = null;
            this.txtConfigText.CharHeight = 14;
            this.txtConfigText.CharWidth = 8;
            this.txtConfigText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfigText.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtConfigText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConfigText.Enabled = false;
            this.txtConfigText.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtConfigText.IsReplaceMode = false;
            this.txtConfigText.Language = FastColoredTextBoxNS.Language.CSharp;
            this.txtConfigText.Location = new System.Drawing.Point(0, 0);
            this.txtConfigText.Name = "txtConfigText";
            this.txtConfigText.Paddings = new System.Windows.Forms.Padding(0);
            this.txtConfigText.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtConfigText.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtConfigText.ServiceColors")));
            this.txtConfigText.Size = new System.Drawing.Size(535, 419);
            this.txtConfigText.TabIndex = 0;
            this.txtConfigText.Text = "fastColoredTextBox1";
            this.txtConfigText.Zoom = 100;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(555, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(636, 7);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "&Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(717, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(1, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(795, 419);
            this.splitContainer1.SplitterDistance = 535;
            this.splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.97136F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.02864F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(256, 419);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTypeCodeLegend);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(3, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TypeCodes";
            // 
            // txtTypeCodeLegend
            // 
            this.txtTypeCodeLegend.AutoCompleteBracketsList = new char[] {
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
            this.txtTypeCodeLegend.AutoScrollMinSize = new System.Drawing.Size(179, 14);
            this.txtTypeCodeLegend.BackBrush = null;
            this.txtTypeCodeLegend.CharHeight = 14;
            this.txtTypeCodeLegend.CharWidth = 8;
            this.txtTypeCodeLegend.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTypeCodeLegend.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtTypeCodeLegend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTypeCodeLegend.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtTypeCodeLegend.IsReplaceMode = false;
            this.txtTypeCodeLegend.Language = FastColoredTextBoxNS.Language.CSharp;
            this.txtTypeCodeLegend.Location = new System.Drawing.Point(3, 16);
            this.txtTypeCodeLegend.Name = "txtTypeCodeLegend";
            this.txtTypeCodeLegend.Paddings = new System.Windows.Forms.Padding(0);
            this.txtTypeCodeLegend.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtTypeCodeLegend.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtTypeCodeLegend.ServiceColors")));
            this.txtTypeCodeLegend.Size = new System.Drawing.Size(244, 194);
            this.txtTypeCodeLegend.TabIndex = 0;
            this.txtTypeCodeLegend.Text = "fastColoredTextBox1";
            this.txtTypeCodeLegend.Zoom = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLegend);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txtLegend
            // 
            this.txtLegend.AutoCompleteBracketsList = new char[] {
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
            this.txtLegend.AutoScrollMinSize = new System.Drawing.Size(179, 14);
            this.txtLegend.BackBrush = null;
            this.txtLegend.CharHeight = 14;
            this.txtLegend.CharWidth = 8;
            this.txtLegend.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLegend.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtLegend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLegend.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtLegend.IsReplaceMode = false;
            this.txtLegend.Language = FastColoredTextBoxNS.Language.CSharp;
            this.txtLegend.Location = new System.Drawing.Point(3, 16);
            this.txtLegend.Name = "txtLegend";
            this.txtLegend.Paddings = new System.Windows.Forms.Padding(0);
            this.txtLegend.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtLegend.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtLegend.ServiceColors")));
            this.txtLegend.Size = new System.Drawing.Size(244, 175);
            this.txtLegend.TabIndex = 0;
            this.txtLegend.Text = "fastColoredTextBox1";
            this.txtLegend.Zoom = 100;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Name = "Form2";
            this.Text = "Node Encrypted Config Managements";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtConfigText)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTypeCodeLegend)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtLegend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FastColoredTextBoxNS.FastColoredTextBox txtConfigText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private FastColoredTextBoxNS.FastColoredTextBox txtTypeCodeLegend;
        private System.Windows.Forms.GroupBox groupBox2;
        private FastColoredTextBoxNS.FastColoredTextBox txtLegend;
    }
}