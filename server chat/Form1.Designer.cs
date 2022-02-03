
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
            this.txtQueue = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtWrite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.queue = new System.Windows.Forms.ComboBox();
            this.labelMessenger = new System.Windows.Forms.Label();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.btnReceive = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txtQueue);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.txtWrite);
            this.panel1.Location = new System.Drawing.Point(146, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 427);
            this.panel1.TabIndex = 0;
            // 
            // txtQueue
            // 
            this.txtQueue.Location = new System.Drawing.Point(14, 5);
            this.txtQueue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQueue.Multiline = true;
            this.txtQueue.Name = "txtQueue";
            this.txtQueue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQueue.Size = new System.Drawing.Size(326, 303);
            this.txtQueue.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(274, 315);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(66, 101);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtWrite
            // 
            this.txtWrite.Location = new System.Drawing.Point(14, 315);
            this.txtWrite.Multiline = true;
            this.txtWrite.Name = "txtWrite";
            this.txtWrite.Size = new System.Drawing.Size(254, 101);
            this.txtWrite.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(629, 49);
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
            this.queue.Location = new System.Drawing.Point(11, 17);
            this.queue.Name = "queue";
            this.queue.Size = new System.Drawing.Size(94, 28);
            this.queue.TabIndex = 2;
            // 
            // labelMessenger
            // 
            this.labelMessenger.AutoSize = true;
            this.labelMessenger.Location = new System.Drawing.Point(826, 42);
            this.labelMessenger.Name = "labelMessenger";
            this.labelMessenger.Size = new System.Drawing.Size(52, 20);
            this.labelMessenger.TabIndex = 0;
            this.labelMessenger.Text = "Queue";
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(505, 109);
            this.txtReceive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(326, 101);
            this.txtReceive.TabIndex = 3;
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(787, 249);
            this.btnReceive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(91, 100);
            this.btnReceive.TabIndex = 4;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.queue);
            this.panel2.Location = new System.Drawing.Point(12, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 427);
            this.panel2.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 51);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 56);
            this.button4.TabIndex = 7;
            this.button4.Text = "Create new room";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 451);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.labelMessenger);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.TextBox txtQueue;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Panel panel2;
    }
}

