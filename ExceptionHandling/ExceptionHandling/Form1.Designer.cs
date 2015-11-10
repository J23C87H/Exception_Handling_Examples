namespace ExceptionHandling
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.custom_Btn = new System.Windows.Forms.Button();
            this.handled_Btn = new System.Windows.Forms.Button();
            this.unhandled_Btn = new System.Windows.Forms.Button();
            this.reset_Btn = new System.Windows.Forms.Button();
            this.exit_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Custom Exception Message:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 1;
            // 
            // custom_Btn
            // 
            this.custom_Btn.Location = new System.Drawing.Point(45, 93);
            this.custom_Btn.Name = "custom_Btn";
            this.custom_Btn.Size = new System.Drawing.Size(163, 23);
            this.custom_Btn.TabIndex = 2;
            this.custom_Btn.Text = "Display Custom Exception";
            this.custom_Btn.UseVisualStyleBackColor = true;
            this.custom_Btn.Click += new System.EventHandler(this.custom_Btn_Click);
            // 
            // handled_Btn
            // 
            this.handled_Btn.Location = new System.Drawing.Point(45, 142);
            this.handled_Btn.Name = "handled_Btn";
            this.handled_Btn.Size = new System.Drawing.Size(163, 23);
            this.handled_Btn.TabIndex = 3;
            this.handled_Btn.Text = "Divide By Zero Handled";
            this.handled_Btn.UseVisualStyleBackColor = true;
            this.handled_Btn.Click += new System.EventHandler(this.handled_Btn_Click);
            // 
            // unhandled_Btn
            // 
            this.unhandled_Btn.Location = new System.Drawing.Point(45, 186);
            this.unhandled_Btn.Name = "unhandled_Btn";
            this.unhandled_Btn.Size = new System.Drawing.Size(163, 23);
            this.unhandled_Btn.TabIndex = 4;
            this.unhandled_Btn.Text = "Divide By Zero NOT Handled";
            this.unhandled_Btn.UseVisualStyleBackColor = true;
            this.unhandled_Btn.Click += new System.EventHandler(this.unhandled_Btn_Click);
            // 
            // reset_Btn
            // 
            this.reset_Btn.Location = new System.Drawing.Point(45, 262);
            this.reset_Btn.Name = "reset_Btn";
            this.reset_Btn.Size = new System.Drawing.Size(75, 23);
            this.reset_Btn.TabIndex = 5;
            this.reset_Btn.Text = "Reset";
            this.reset_Btn.UseVisualStyleBackColor = true;
            this.reset_Btn.Click += new System.EventHandler(this.reset_Btn_Click);
            // 
            // exit_Btn
            // 
            this.exit_Btn.Location = new System.Drawing.Point(180, 262);
            this.exit_Btn.Name = "exit_Btn";
            this.exit_Btn.Size = new System.Drawing.Size(75, 23);
            this.exit_Btn.TabIndex = 6;
            this.exit_Btn.Text = "Exit";
            this.exit_Btn.UseVisualStyleBackColor = true;
            this.exit_Btn.Click += new System.EventHandler(this.exit_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 330);
            this.Controls.Add(this.exit_Btn);
            this.Controls.Add(this.reset_Btn);
            this.Controls.Add(this.unhandled_Btn);
            this.Controls.Add(this.handled_Btn);
            this.Controls.Add(this.custom_Btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button custom_Btn;
        private System.Windows.Forms.Button handled_Btn;
        private System.Windows.Forms.Button unhandled_Btn;
        private System.Windows.Forms.Button reset_Btn;
        private System.Windows.Forms.Button exit_Btn;
    }
}

