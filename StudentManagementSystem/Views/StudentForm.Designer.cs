namespace StudentManagementSystem.Views
{
    partial class StudentForm
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
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            btnAdd = new Button();
            btnLoad = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(340, 30);
            label1.Name = "label1";
            label1.Size = new Size(323, 31);
            label1.TabIndex = 0;
            label1.Text = "Student Management Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(143, 111);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 1;
            label2.Text = "Input Name:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(403, 111);
            txtName.Name = "txtName";
            txtName.Size = new Size(182, 34);
            txtName.TabIndex = 2;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(403, 213);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(182, 34);
            txtAge.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(143, 213);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 3;
            label3.Text = "Input Age:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(403, 311);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(182, 34);
            txtEmail.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(143, 311);
            label4.Name = "label4";
            label4.Size = new Size(114, 28);
            label4.TabIndex = 5;
            label4.Text = "Input Email:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Transparent;
            btnAdd.Location = new Point(728, 111);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(186, 51);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add Student";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.DarkViolet;
            btnLoad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoad.ForeColor = Color.Transparent;
            btnLoad.Location = new Point(728, 208);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(186, 55);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "Display Students";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 516);
            Controls.Add(btnLoad);
            Controls.Add(btnAdd);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtAge);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentForm";
            Text = "StudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtAge;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private Button btnAdd;
        private Button btnLoad;
    }
}