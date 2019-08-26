namespace Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btGui = new System.Windows.Forms.Button();
            this.tbLichSu = new System.Windows.Forms.TextBox();
            this.tbNoiDung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btGui
            // 
            this.btGui.Location = new System.Drawing.Point(331, 405);
            this.btGui.Name = "btGui";
            this.btGui.Size = new System.Drawing.Size(71, 69);
            this.btGui.TabIndex = 0;
            this.btGui.Text = "Gửi";
            this.btGui.UseVisualStyleBackColor = true;
            this.btGui.Click += new System.EventHandler(this.btGui_Click);
            // 
            // tbLichSu
            // 
            this.tbLichSu.Location = new System.Drawing.Point(12, 25);
            this.tbLichSu.Multiline = true;
            this.tbLichSu.Name = "tbLichSu";
            this.tbLichSu.ReadOnly = true;
            this.tbLichSu.Size = new System.Drawing.Size(387, 361);
            this.tbLichSu.TabIndex = 1;
            // 
            // tbNoiDung
            // 
            this.tbNoiDung.Location = new System.Drawing.Point(12, 405);
            this.tbNoiDung.Multiline = true;
            this.tbNoiDung.Name = "tbNoiDung";
            this.tbNoiDung.Size = new System.Drawing.Size(313, 69);
            this.tbNoiDung.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lịch sử nhắn tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cửa sổ soạn thảo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 486);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNoiDung);
            this.Controls.Add(this.tbLichSu);
            this.Controls.Add(this.btGui);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "My Messager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGui;
        private System.Windows.Forms.TextBox tbLichSu;
        private System.Windows.Forms.TextBox tbNoiDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

