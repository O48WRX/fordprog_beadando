namespace forditoprog
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
            this.label3 = new System.Windows.Forms.Label();
            this.kifejezes = new System.Windows.Forms.TextBox();
            this.accept = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(2, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bemenet:";
            // 
            // kifejezes
            // 
            this.kifejezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kifejezes.Location = new System.Drawing.Point(102, 30);
            this.kifejezes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kifejezes.Name = "kifejezes";
            this.kifejezes.Size = new System.Drawing.Size(168, 29);
            this.kifejezes.TabIndex = 5;
            // 
            // accept
            // 
            this.accept.BackColor = System.Drawing.Color.Red;
            this.accept.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.accept.Location = new System.Drawing.Point(141, 72);
            this.accept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(87, 30);
            this.accept.TabIndex = 8;
            this.accept.Text = "Számolás";
            this.accept.UseVisualStyleBackColor = false;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(274, 30);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(317, 331);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(389, 370);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Szabály tábla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // deleteOutput
            // 
            this.deleteOutput.BackColor = System.Drawing.Color.Red;
            this.deleteOutput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteOutput.Location = new System.Drawing.Point(141, 127);
            this.deleteOutput.Margin = new System.Windows.Forms.Padding(2);
            this.deleteOutput.Name = "deleteOutput";
            this.deleteOutput.Size = new System.Drawing.Size(87, 30);
            this.deleteOutput.TabIndex = 11;
            this.deleteOutput.Text = "Töröl";
            this.deleteOutput.UseVisualStyleBackColor = false;
            this.deleteOutput.Click += new System.EventHandler(this.deleteOutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(600, 407);
            this.Controls.Add(this.deleteOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.kifejezes);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kifejezes;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deleteOutput;
    }
}

