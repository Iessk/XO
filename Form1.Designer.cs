namespace XO1
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
            this.btnRestart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.PB20 = new System.Windows.Forms.PictureBox();
            this.PB01 = new System.Windows.Forms.PictureBox();
            this.PB00 = new System.Windows.Forms.PictureBox();
            this.PB12 = new System.Windows.Forms.PictureBox();
            this.PB11 = new System.Windows.Forms.PictureBox();
            this.PB10 = new System.Windows.Forms.PictureBox();
            this.PB22 = new System.Windows.Forms.PictureBox();
            this.PB21 = new System.Windows.Forms.PictureBox();
            this.PB02 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB02)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRestart.Location = new System.Drawing.Point(38, 342);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(155, 58);
            this.btnRestart.TabIndex = 9;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(31, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "Winner : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(31, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "Turn : ";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTurn.Location = new System.Drawing.Point(70, 161);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(84, 23);
            this.lblTurn.TabIndex = 12;
            this.lblTurn.Text = "Player1";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblWinner.Location = new System.Drawing.Point(70, 272);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(123, 23);
            this.lblWinner.TabIndex = 13;
            this.lblWinner.Text = "In progress";
            // 
            // PB20
            // 
            this.PB20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB20.BackgroundImage")));
            this.PB20.Location = new System.Drawing.Point(363, 285);
            this.PB20.Name = "PB20";
            this.PB20.Size = new System.Drawing.Size(96, 104);
            this.PB20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB20.TabIndex = 1;
            this.PB20.TabStop = false;
            this.PB20.Click += new System.EventHandler(this.PB_Click);
            // 
            // PB01
            // 
            this.PB01.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB01.BackgroundImage")));
            this.PB01.Location = new System.Drawing.Point(479, 49);
            this.PB01.Name = "PB01";
            this.PB01.Size = new System.Drawing.Size(96, 104);
            this.PB01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB01.TabIndex = 8;
            this.PB01.TabStop = false;
            this.PB01.Click += new System.EventHandler(this.PB_Click);
            // 
            // PB00
            // 
            this.PB00.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB00.BackgroundImage")));
            this.PB00.Location = new System.Drawing.Point(363, 49);
            this.PB00.Name = "PB00";
            this.PB00.Size = new System.Drawing.Size(96, 104);
            this.PB00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB00.TabIndex = 0;
            this.PB00.TabStop = false;
            this.PB00.Click += new System.EventHandler(this.PB_Click);
            // 
            // PB12
            // 
            this.PB12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB12.BackgroundImage")));
            this.PB12.Location = new System.Drawing.Point(591, 175);
            this.PB12.Name = "PB12";
            this.PB12.Size = new System.Drawing.Size(96, 104);
            this.PB12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB12.TabIndex = 6;
            this.PB12.TabStop = false;
            this.PB12.Click += new System.EventHandler(this.PB_Click);
            // 
            // PB11
            // 
            this.PB11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB11.BackgroundImage")));
            this.PB11.Location = new System.Drawing.Point(479, 175);
            this.PB11.Name = "PB11";
            this.PB11.Size = new System.Drawing.Size(96, 104);
            this.PB11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB11.TabIndex = 5;
            this.PB11.TabStop = false;
            this.PB11.Click += new System.EventHandler(this.PB_Click);
            // 
            // PB10
            // 
            this.PB10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB10.BackgroundImage")));
            this.PB10.Location = new System.Drawing.Point(363, 175);
            this.PB10.Name = "PB10";
            this.PB10.Size = new System.Drawing.Size(96, 104);
            this.PB10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB10.TabIndex = 4;
            this.PB10.TabStop = false;
            this.PB10.Click += new System.EventHandler(this.PB_Click);
            // 
            // PB22
            // 
            this.PB22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB22.BackgroundImage")));
            this.PB22.Location = new System.Drawing.Point(591, 285);
            this.PB22.Name = "PB22";
            this.PB22.Size = new System.Drawing.Size(96, 104);
            this.PB22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB22.TabIndex = 3;
            this.PB22.TabStop = false;
            this.PB22.Click += new System.EventHandler(this.PB_Click);
            // 
            // PB21
            // 
            this.PB21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB21.BackgroundImage")));
            this.PB21.Location = new System.Drawing.Point(479, 285);
            this.PB21.Name = "PB21";
            this.PB21.Size = new System.Drawing.Size(96, 104);
            this.PB21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB21.TabIndex = 2;
            this.PB21.TabStop = false;
            this.PB21.Click += new System.EventHandler(this.PB_Click);
            // 
            // PB02
            // 
            this.PB02.BackgroundImage = global::XO1.Properties.Resources.QMark;
            this.PB02.Location = new System.Drawing.Point(591, 49);
            this.PB02.Name = "PB02";
            this.PB02.Size = new System.Drawing.Size(96, 104);
            this.PB02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB02.TabIndex = 7;
            this.PB02.TabStop = false;
            this.PB02.Click += new System.EventHandler(this.PB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.PB20);
            this.Controls.Add(this.PB01);
            this.Controls.Add(this.PB02);
            this.Controls.Add(this.PB00);
            this.Controls.Add(this.PB12);
            this.Controls.Add(this.PB11);
            this.Controls.Add(this.PB10);
            this.Controls.Add(this.PB22);
            this.Controls.Add(this.PB21);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestart);
            this.Name = "Form1";
            this.Text = "XO game";
            ((System.ComponentModel.ISupportInitialize)(this.PB20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB02)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB00;
        private System.Windows.Forms.PictureBox PB20;
        private System.Windows.Forms.PictureBox PB21;
        private System.Windows.Forms.PictureBox PB22;
        private System.Windows.Forms.PictureBox PB10;
        private System.Windows.Forms.PictureBox PB11;
        private System.Windows.Forms.PictureBox PB12;
        private System.Windows.Forms.PictureBox PB01;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.PictureBox PB02;
    }
}

