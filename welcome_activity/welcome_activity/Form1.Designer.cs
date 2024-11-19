namespace welcome_activity
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
            this.lblPrompt = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnGreetMe = new System.Windows.Forms.Button();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(229, 9);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(84, 13);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "Enter your name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(232, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnGreetMe
            // 
            this.btnGreetMe.Location = new System.Drawing.Point(238, 83);
            this.btnGreetMe.Name = "btnGreetMe";
            this.btnGreetMe.Size = new System.Drawing.Size(75, 23);
            this.btnGreetMe.TabIndex = 2;
            this.btnGreetMe.Text = "Greet Me";
            this.btnGreetMe.UseVisualStyleBackColor = true;
            this.btnGreetMe.Click += new System.EventHandler(this.btnGreetMe_Click);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Location = new System.Drawing.Point(246, 136);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(45, 13);
            this.lblGreeting.TabIndex = 3;
            this.lblGreeting.Text = "HELLO!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.btnGreetMe);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPrompt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnGreetMe;
        private System.Windows.Forms.Label lblGreeting;
    }
}

