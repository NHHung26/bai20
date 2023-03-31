namespace bai20
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            listNhom1 = new ListBox();
            listNhom2 = new ListBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(60, 9);
            label1.Name = "label1";
            label1.Size = new Size(469, 38);
            label1.TabIndex = 0;
            label1.Text = "CHƯƠNG TRÌNH QUẢN LÍ CA HỌC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 76);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên sinh viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 132);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 2;
            label3.Text = "Chọn nhóm";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 69);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 39);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(421, 69);
            button1.Name = "button1";
            button1.Size = new Size(175, 43);
            button1.TabIndex = 5;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(421, 124);
            button2.Name = "button2";
            button2.Size = new Size(175, 42);
            button2.TabIndex = 6;
            button2.Text = "Thoát chương trình";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 194);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 7;
            label4.Text = "Nhóm 1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(406, 194);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 8;
            label5.Text = "Nhóm 2";
            // 
            // listNhom1
            // 
            listNhom1.FormattingEnabled = true;
            listNhom1.ItemHeight = 20;
            listNhom1.Location = new Point(12, 234);
            listNhom1.Name = "listNhom1";
            listNhom1.Size = new Size(199, 204);
            listNhom1.TabIndex = 9;
            // 
            // listNhom2
            // 
            listNhom2.FormattingEnabled = true;
            listNhom2.ItemHeight = 20;
            listNhom2.Location = new Point(369, 234);
            listNhom2.Name = "listNhom2";
            listNhom2.Size = new Size(204, 204);
            listNhom2.TabIndex = 10;
            // 
            // button3
            // 
            button3.Location = new Point(217, 298);
            button3.Name = "button3";
            button3.Size = new Size(71, 29);
            button3.TabIndex = 11;
            button3.Text = ">";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(294, 298);
            button4.Name = "button4";
            button4.Size = new Size(69, 29);
            button4.TabIndex = 12;
            button4.Text = "<";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(217, 359);
            button5.Name = "button5";
            button5.Size = new Size(71, 29);
            button5.TabIndex = 13;
            button5.Text = ">>";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(294, 359);
            button6.Name = "button6";
            button6.Size = new Size(69, 29);
            button6.TabIndex = 14;
            button6.Text = "<<";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(250, 409);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 15;
            button7.Text = "Xóa";
            button7.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nhóm 1", "Nhóm 2" });
            comboBox1.Location = new Point(103, 132);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(301, 28);
            comboBox1.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 462);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 17;
            label6.Text = "Tổng số";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(369, 462);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 18;
            label7.Text = "Tổng số";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 491);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(listNhom2);
            Controls.Add(listNhom1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label label5;
        private ListBox listNhom1;
        private ListBox listNhom2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private ComboBox comboBox1;
        private Label label6;
        private Label label7;
    }
}