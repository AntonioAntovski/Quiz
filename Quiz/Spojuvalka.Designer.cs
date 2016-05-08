namespace Quiz
{
    partial class Spojuvalka
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
            this.lstLevo = new System.Windows.Forms.ListBox();
            this.lstDesno = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPoeni = new System.Windows.Forms.Label();
            this.btnNextGame = new System.Windows.Forms.Button();
            this.txtBoxSign = new System.Windows.Forms.TextBox();
            this.txtBoxOpis = new System.Windows.Forms.TextBox();
            this.btnPravila = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLevo
            // 
            this.lstLevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLevo.FormattingEnabled = true;
            this.lstLevo.ItemHeight = 25;
            this.lstLevo.Location = new System.Drawing.Point(12, 86);
            this.lstLevo.Name = "lstLevo";
            this.lstLevo.Size = new System.Drawing.Size(230, 254);
            this.lstLevo.TabIndex = 0;
            this.lstLevo.SelectedIndexChanged += new System.EventHandler(this.lstLevo_SelectedIndexChanged);
            // 
            // lstDesno
            // 
            this.lstDesno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDesno.FormattingEnabled = true;
            this.lstDesno.ItemHeight = 25;
            this.lstDesno.Location = new System.Drawing.Point(360, 86);
            this.lstDesno.Name = "lstDesno";
            this.lstDesno.Size = new System.Drawing.Size(230, 254);
            this.lstDesno.TabIndex = 1;
            this.lstDesno.SelectedIndexChanged += new System.EventHandler(this.lstDesno_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поени:";
            // 
            // lblPoeni
            // 
            this.lblPoeni.AutoSize = true;
            this.lblPoeni.Location = new System.Drawing.Point(95, 362);
            this.lblPoeni.Name = "lblPoeni";
            this.lblPoeni.Size = new System.Drawing.Size(13, 13);
            this.lblPoeni.TabIndex = 3;
            this.lblPoeni.Text = "0";
            // 
            // btnNextGame
            // 
            this.btnNextGame.Location = new System.Drawing.Point(479, 346);
            this.btnNextGame.Name = "btnNextGame";
            this.btnNextGame.Size = new System.Drawing.Size(111, 39);
            this.btnNextGame.TabIndex = 4;
            this.btnNextGame.Text = "Следна игра";
            this.btnNextGame.UseVisualStyleBackColor = true;
            this.btnNextGame.Visible = false;
            this.btnNextGame.Click += new System.EventHandler(this.btnNextGame_Click);
            // 
            // txtBoxSign
            // 
            this.txtBoxSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSign.Location = new System.Drawing.Point(248, 86);
            this.txtBoxSign.Multiline = true;
            this.txtBoxSign.Name = "txtBoxSign";
            this.txtBoxSign.Size = new System.Drawing.Size(106, 254);
            this.txtBoxSign.TabIndex = 5;
            this.txtBoxSign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxSign.Visible = false;
            // 
            // txtBoxOpis
            // 
            this.txtBoxOpis.Enabled = false;
            this.txtBoxOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOpis.Location = new System.Drawing.Point(12, 5);
            this.txtBoxOpis.Multiline = true;
            this.txtBoxOpis.Name = "txtBoxOpis";
            this.txtBoxOpis.Size = new System.Drawing.Size(555, 35);
            this.txtBoxOpis.TabIndex = 6;
            // 
            // btnPravila
            // 
            this.btnPravila.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPravila.Location = new System.Drawing.Point(12, 46);
            this.btnPravila.Name = "btnPravila";
            this.btnPravila.Size = new System.Drawing.Size(105, 34);
            this.btnPravila.TabIndex = 7;
            this.btnPravila.Text = "Правила";
            this.btnPravila.UseVisualStyleBackColor = true;
            this.btnPravila.Click += new System.EventHandler(this.btnPravila_Click);
            // 
            // Spojuvalka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 397);
            this.Controls.Add(this.btnPravila);
            this.Controls.Add(this.txtBoxOpis);
            this.Controls.Add(this.txtBoxSign);
            this.Controls.Add(this.btnNextGame);
            this.Controls.Add(this.lblPoeni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDesno);
            this.Controls.Add(this.lstLevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Spojuvalka";
            this.Text = "Спојувалка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLevo;
        private System.Windows.Forms.ListBox lstDesno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPoeni;
        private System.Windows.Forms.Button btnNextGame;
        private System.Windows.Forms.TextBox txtBoxSign;
        private System.Windows.Forms.TextBox txtBoxOpis;
        private System.Windows.Forms.Button btnPravila;
    }
}

