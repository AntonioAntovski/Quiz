namespace Quiz
{
    partial class Prashanja
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
            this.components = new System.ComponentModel.Container();
            this.odg1 = new System.Windows.Forms.Button();
            this.odg2 = new System.Windows.Forms.Button();
            this.odg3 = new System.Windows.Forms.Button();
            this.odg4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPrashanje = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSledna = new System.Windows.Forms.Button();
            this.lblPoeni = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // odg1
            // 
            this.odg1.Location = new System.Drawing.Point(6, 31);
            this.odg1.Name = "odg1";
            this.odg1.Size = new System.Drawing.Size(680, 36);
            this.odg1.TabIndex = 0;
            this.odg1.UseVisualStyleBackColor = true;
            this.odg1.Click += new System.EventHandler(this.odg1_Click);
            // 
            // odg2
            // 
            this.odg2.Location = new System.Drawing.Point(6, 73);
            this.odg2.Name = "odg2";
            this.odg2.Size = new System.Drawing.Size(680, 36);
            this.odg2.TabIndex = 1;
            this.odg2.UseVisualStyleBackColor = true;
            this.odg2.Click += new System.EventHandler(this.odg2_Click);
            // 
            // odg3
            // 
            this.odg3.Location = new System.Drawing.Point(6, 115);
            this.odg3.Name = "odg3";
            this.odg3.Size = new System.Drawing.Size(680, 36);
            this.odg3.TabIndex = 2;
            this.odg3.UseVisualStyleBackColor = true;
            this.odg3.Click += new System.EventHandler(this.odg3_Click);
            // 
            // odg4
            // 
            this.odg4.Location = new System.Drawing.Point(6, 157);
            this.odg4.Name = "odg4";
            this.odg4.Size = new System.Drawing.Size(680, 36);
            this.odg4.TabIndex = 3;
            this.odg4.UseVisualStyleBackColor = true;
            this.odg4.Click += new System.EventHandler(this.odg4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPrashanje);
            this.groupBox3.Location = new System.Drawing.Point(13, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(692, 128);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Прашање";
            // 
            // lblPrashanje
            // 
            this.lblPrashanje.AutoSize = true;
            this.lblPrashanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblPrashanje.Location = new System.Drawing.Point(6, 26);
            this.lblPrashanje.Name = "lblPrashanje";
            this.lblPrashanje.Size = new System.Drawing.Size(0, 29);
            this.lblPrashanje.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 382);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(692, 32);
            this.progressBar1.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Interval = 1200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.odg4);
            this.groupBox1.Controls.Add(this.odg1);
            this.groupBox1.Controls.Add(this.odg2);
            this.groupBox1.Controls.Add(this.odg3);
            this.groupBox1.Location = new System.Drawing.Point(12, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 199);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Одговори";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 30);
            this.label1.TabIndex = 0;
            // 
            // btnSledna
            // 
            this.btnSledna.Location = new System.Drawing.Point(452, 433);
            this.btnSledna.Name = "btnSledna";
            this.btnSledna.Size = new System.Drawing.Size(246, 34);
            this.btnSledna.TabIndex = 18;
            this.btnSledna.Text = "Следна игра";
            this.btnSledna.UseVisualStyleBackColor = true;
            this.btnSledna.Click += new System.EventHandler(this.btnSledna_Click);
            // 
            // lblPoeni
            // 
            this.lblPoeni.AutoSize = true;
            this.lblPoeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoeni.Location = new System.Drawing.Point(638, 349);
            this.lblPoeni.Name = "lblPoeni";
            this.lblPoeni.Size = new System.Drawing.Size(0, 24);
            this.lblPoeni.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(575, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Поени:";
            // 
            // Prashanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 479);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPoeni);
            this.Controls.Add(this.btnSledna);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Prashanja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прашања";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odg1;
        private System.Windows.Forms.Button odg2;
        private System.Windows.Forms.Button odg3;
        private System.Windows.Forms.Button odg4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblPrashanje;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSledna;
        private System.Windows.Forms.Label lblPoeni;
        private System.Windows.Forms.Label label2;
    }
}