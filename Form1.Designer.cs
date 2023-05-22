namespace AfterProcessing
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txt_file = new System.Windows.Forms.TextBox();
            this.chkbx_4 = new System.Windows.Forms.CheckBox();
            this.chkbx_5 = new System.Windows.Forms.CheckBox();
            this.txt_4 = new System.Windows.Forms.TextBox();
            this.txt_5 = new System.Windows.Forms.TextBox();
            this.ProcessBtn = new System.Windows.Forms.Button();
            this.listbox_org = new System.Windows.Forms.ListBox();
            this.listbox_after = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_progname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selMachineType = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "打开文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txt_file
            // 
            this.txt_file.Location = new System.Drawing.Point(156, 33);
            this.txt_file.Name = "txt_file";
            this.txt_file.Size = new System.Drawing.Size(406, 25);
            this.txt_file.TabIndex = 1;
            // 
            // chkbx_4
            // 
            this.chkbx_4.AutoSize = true;
            this.chkbx_4.Location = new System.Drawing.Point(622, 34);
            this.chkbx_4.Name = "chkbx_4";
            this.chkbx_4.Size = new System.Drawing.Size(52, 19);
            this.chkbx_4.TabIndex = 4;
            this.chkbx_4.Text = "4轴";
            this.chkbx_4.UseVisualStyleBackColor = true;
            // 
            // chkbx_5
            // 
            this.chkbx_5.AutoSize = true;
            this.chkbx_5.Location = new System.Drawing.Point(773, 34);
            this.chkbx_5.Name = "chkbx_5";
            this.chkbx_5.Size = new System.Drawing.Size(52, 19);
            this.chkbx_5.TabIndex = 5;
            this.chkbx_5.Text = "5轴";
            this.chkbx_5.UseVisualStyleBackColor = true;
            // 
            // txt_4
            // 
            this.txt_4.Location = new System.Drawing.Point(680, 31);
            this.txt_4.Name = "txt_4";
            this.txt_4.Size = new System.Drawing.Size(76, 25);
            this.txt_4.TabIndex = 6;
            this.txt_4.Text = "B";
            this.txt_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_5
            // 
            this.txt_5.Location = new System.Drawing.Point(831, 31);
            this.txt_5.Name = "txt_5";
            this.txt_5.Size = new System.Drawing.Size(76, 25);
            this.txt_5.TabIndex = 7;
            this.txt_5.Text = "C";
            this.txt_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProcessBtn
            // 
            this.ProcessBtn.Location = new System.Drawing.Point(734, 817);
            this.ProcessBtn.Name = "ProcessBtn";
            this.ProcessBtn.Size = new System.Drawing.Size(162, 68);
            this.ProcessBtn.TabIndex = 8;
            this.ProcessBtn.Text = "处理文件";
            this.ProcessBtn.UseVisualStyleBackColor = true;
            this.ProcessBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // listbox_org
            // 
            this.listbox_org.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listbox_org.FormattingEnabled = true;
            this.listbox_org.Location = new System.Drawing.Point(86, 109);
            this.listbox_org.Name = "listbox_org";
            this.listbox_org.Size = new System.Drawing.Size(994, 329);
            this.listbox_org.TabIndex = 9;
            this.listbox_org.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Listbox_org_DrawItem);
            // 
            // listbox_after
            // 
            this.listbox_after.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listbox_after.FormattingEnabled = true;
            this.listbox_after.ItemHeight = 15;
            this.listbox_after.Location = new System.Drawing.Point(84, 457);
            this.listbox_after.Name = "listbox_after";
            this.listbox_after.Size = new System.Drawing.Size(994, 334);
            this.listbox_after.TabIndex = 10;
            this.listbox_after.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Listbox_after_DrawItem);
            this.listbox_after.MouseCaptureChanged += new System.EventHandler(this.Listbox_after_MouseCaptureChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(916, 817);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 68);
            this.button2.TabIndex = 11;
            this.button2.Text = "保存文件";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // txt_progname
            // 
            this.txt_progname.Location = new System.Drawing.Point(680, 72);
            this.txt_progname.Name = "txt_progname";
            this.txt_progname.Size = new System.Drawing.Size(227, 25);
            this.txt_progname.TabIndex = 12;
            this.txt_progname.Text = "Axis_Ctrl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "子程序名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "程序文件";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(913, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "系统类型";
            // 
            // selMachineType
            // 
            this.selMachineType.FormattingEnabled = true;
            this.selMachineType.Items.AddRange(new object[] {
            "fanuc",
            "siemens"});
            this.selMachineType.Location = new System.Drawing.Point(986, 72);
            this.selMachineType.Name = "selMachineType";
            this.selMachineType.Size = new System.Drawing.Size(94, 23);
            this.selMachineType.TabIndex = 16;
            this.selMachineType.SelectedIndexChanged += new System.EventHandler(this.SelMachineType_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(986, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 25);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = "2000";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(918, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 19);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "转速";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 897);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.selMachineType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_progname);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listbox_after);
            this.Controls.Add(this.listbox_org);
            this.Controls.Add(this.ProcessBtn);
            this.Controls.Add(this.txt_5);
            this.Controls.Add(this.txt_4);
            this.Controls.Add(this.chkbx_5);
            this.Controls.Add(this.chkbx_4);
            this.Controls.Add(this.txt_file);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "扩展轴后处理程序";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_file;
        private System.Windows.Forms.CheckBox chkbx_4;
        private System.Windows.Forms.CheckBox chkbx_5;
        private System.Windows.Forms.TextBox txt_4;
        private System.Windows.Forms.TextBox txt_5;
        private System.Windows.Forms.Button ProcessBtn;
        private System.Windows.Forms.ListBox listbox_org;
        private System.Windows.Forms.ListBox listbox_after;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_progname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selMachineType;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

