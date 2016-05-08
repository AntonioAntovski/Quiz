namespace Quiz
{
    partial class Pravila
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
            this.txtPravila = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPravila
            // 
            this.txtPravila.Enabled = false;
            this.txtPravila.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPravila.Location = new System.Drawing.Point(13, 13);
            this.txtPravila.Multiline = true;
            this.txtPravila.Name = "txtPravila";
            this.txtPravila.ReadOnly = true;
            this.txtPravila.Size = new System.Drawing.Size(446, 154);
            this.txtPravila.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Pravila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 222);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPravila);
            this.Name = "Pravila";
            this.Text = "Pravila";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPravila;
        private System.Windows.Forms.Button button1;
    }
}