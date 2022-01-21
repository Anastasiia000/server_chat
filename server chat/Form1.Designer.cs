
namespace server_chat {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.queue = new System.Windows.Forms.ComboBox();
            this.txtWrite = new System.Windows.Forms.TextBox();
            this.labelMessenger = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.queue);
            this.panel1.Controls.Add(this.txtWrite);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 426);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Send to";
            // 
            // queue
            // 
            this.queue.FormattingEnabled = true;
            this.queue.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "everyone"});
            this.queue.Location = new System.Drawing.Point(91, 236);
            this.queue.Name = "queue";
            this.queue.Size = new System.Drawing.Size(251, 28);
            this.queue.TabIndex = 2;
            // 
            // txtWrite
            // 
            this.txtWrite.Location = new System.Drawing.Point(11, 314);
            this.txtWrite.Multiline = true;
            this.txtWrite.Name = "txtWrite";
            this.txtWrite.Size = new System.Drawing.Size(259, 101);
            this.txtWrite.TabIndex = 1;
            // 
            // labelMessenger
            // 
            this.labelMessenger.AutoSize = true;
            this.labelMessenger.Location = new System.Drawing.Point(503, 42);
            this.labelMessenger.Name = "labelMessenger";
            this.labelMessenger.Size = new System.Drawing.Size(50, 20);
            this.labelMessenger.TabIndex = 0;
            this.labelMessenger.Text = "label1";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(288, 326);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(66, 101);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMessenger);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMessenger;
        private System.Windows.Forms.TextBox txtWrite;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox queue;
    }
}

