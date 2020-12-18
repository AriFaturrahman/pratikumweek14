namespace pratikumweek14
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
            this.labelinput = new System.Windows.Forms.Label();
            this.textBoxinput = new System.Windows.Forms.TextBox();
            this.buttonreverse = new System.Windows.Forms.Button();
            this.buttonurut = new System.Windows.Forms.Button();
            this.labeloutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelinput
            // 
            this.labelinput.AutoSize = true;
            this.labelinput.Location = new System.Drawing.Point(12, 22);
            this.labelinput.Name = "labelinput";
            this.labelinput.Size = new System.Drawing.Size(31, 13);
            this.labelinput.TabIndex = 0;
            this.labelinput.Text = "Input";
            // 
            // textBoxinput
            // 
            this.textBoxinput.Location = new System.Drawing.Point(15, 48);
            this.textBoxinput.Name = "textBoxinput";
            this.textBoxinput.Size = new System.Drawing.Size(155, 20);
            this.textBoxinput.TabIndex = 1;
            // 
            // buttonreverse
            // 
            this.buttonreverse.Location = new System.Drawing.Point(15, 92);
            this.buttonreverse.Name = "buttonreverse";
            this.buttonreverse.Size = new System.Drawing.Size(50, 23);
            this.buttonreverse.TabIndex = 2;
            this.buttonreverse.Text = "reverse";
            this.buttonreverse.UseVisualStyleBackColor = true;
            this.buttonreverse.Click += new System.EventHandler(this.buttonreverse_Click);
            // 
            // buttonurut
            // 
            this.buttonurut.Location = new System.Drawing.Point(95, 92);
            this.buttonurut.Name = "buttonurut";
            this.buttonurut.Size = new System.Drawing.Size(52, 23);
            this.buttonurut.TabIndex = 3;
            this.buttonurut.Text = "urutkan";
            this.buttonurut.UseVisualStyleBackColor = true;
            // 
            // labeloutput
            // 
            this.labeloutput.AutoSize = true;
            this.labeloutput.Location = new System.Drawing.Point(12, 200);
            this.labeloutput.Name = "labeloutput";
            this.labeloutput.Size = new System.Drawing.Size(39, 13);
            this.labeloutput.TabIndex = 4;
            this.labeloutput.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labeloutput);
            this.Controls.Add(this.buttonurut);
            this.Controls.Add(this.buttonreverse);
            this.Controls.Add(this.textBoxinput);
            this.Controls.Add(this.labelinput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelinput;
        private System.Windows.Forms.TextBox textBoxinput;
        private System.Windows.Forms.Button buttonreverse;
        private System.Windows.Forms.Button buttonurut;
        private System.Windows.Forms.Label labeloutput;
    }
}

