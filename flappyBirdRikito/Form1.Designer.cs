namespace flappyBirdRikito
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
            this.components = new System.ComponentModel.Container();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.flappybird = new System.Windows.Forms.PictureBox();
            this.endText1 = new System.Windows.Forms.Label();
            this.endText2 = new System.Windows.Forms.Label();
            this.gameDesigner = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.Explain1 = new System.Windows.Forms.Label();
            this.Explain2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.scoreText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.TextBox();
            this.name2 = new System.Windows.Forms.TextBox();
            this.name3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.score1 = new System.Windows.Forms.TextBox();
            this.score2 = new System.Windows.Forms.TextBox();
            this.score3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Image = global::flappyBirdRikito.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(0, 424);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(517, 83);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::flappyBirdRikito.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(425, 330);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(61, 181);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 2;
            this.pipeBottom.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::flappyBirdRikito.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(425, -60);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(61, 181);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 1;
            this.pipeTop.TabStop = false;
            // 
            // flappybird
            // 
            this.flappybird.Image = global::flappyBirdRikito.Properties.Resources.bird;
            this.flappybird.Location = new System.Drawing.Point(25, 146);
            this.flappybird.Name = "flappybird";
            this.flappybird.Size = new System.Drawing.Size(41, 35);
            this.flappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappybird.TabIndex = 0;
            this.flappybird.TabStop = false;
            // 
            // endText1
            // 
            this.endText1.AutoSize = true;
            this.endText1.Font = new System.Drawing.Font("MS UI Gothic", 50F);
            this.endText1.ForeColor = System.Drawing.SystemColors.Control;
            this.endText1.Location = new System.Drawing.Point(92, 86);
            this.endText1.Name = "endText1";
            this.endText1.Size = new System.Drawing.Size(341, 67);
            this.endText1.TabIndex = 4;
            this.endText1.Text = "GameOver!";
            // 
            // endText2
            // 
            this.endText2.AutoSize = true;
            this.endText2.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.endText2.ForeColor = System.Drawing.SystemColors.Control;
            this.endText2.Location = new System.Drawing.Point(113, 181);
            this.endText2.Name = "endText2";
            this.endText2.Size = new System.Drawing.Size(223, 27);
            this.endText2.TabIndex = 5;
            this.endText2.Text = "Your Final Score : ";
            // 
            // gameDesigner
            // 
            this.gameDesigner.AutoSize = true;
            this.gameDesigner.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.gameDesigner.ForeColor = System.Drawing.SystemColors.Control;
            this.gameDesigner.Location = new System.Drawing.Point(132, 481);
            this.gameDesigner.Name = "gameDesigner";
            this.gameDesigner.Size = new System.Drawing.Size(240, 16);
            this.gameDesigner.TabIndex = 7;
            this.gameDesigner.Text = "Game Designed By Rikito Nakmura";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 15;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Explain1
            // 
            this.Explain1.AutoSize = true;
            this.Explain1.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Explain1.ForeColor = System.Drawing.SystemColors.Control;
            this.Explain1.Location = new System.Drawing.Point(113, 239);
            this.Explain1.Name = "Explain1";
            this.Explain1.Size = new System.Drawing.Size(299, 27);
            this.Explain1.TabIndex = 8;
            this.Explain1.Text = "Click Display: Start Game";
            // 
            // Explain2
            // 
            this.Explain2.AutoSize = true;
            this.Explain2.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Explain2.ForeColor = System.Drawing.SystemColors.Control;
            this.Explain2.Location = new System.Drawing.Point(113, 276);
            this.Explain2.Name = "Explain2";
            this.Explain2.Size = new System.Drawing.Size(261, 27);
            this.Explain2.TabIndex = 9;
            this.Explain2.Text = "Press Space: Jumping";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(545, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 444);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(116, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "ADD YOUR NAME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // scoreText
            // 
            this.scoreText.Location = new System.Drawing.Point(12, 12);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(27, 19);
            this.scoreText.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(133, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "RANK 1 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(133, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "RANK 2 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(133, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "RANK 3 : ";
            // 
            // name1
            // 
            this.name1.Enabled = false;
            this.name1.Location = new System.Drawing.Point(187, 340);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(100, 19);
            this.name1.TabIndex = 19;
            this.name1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name2
            // 
            this.name2.Enabled = false;
            this.name2.Location = new System.Drawing.Point(187, 365);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(100, 19);
            this.name2.TabIndex = 20;
            this.name2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name3
            // 
            this.name3.Enabled = false;
            this.name3.Location = new System.Drawing.Point(187, 390);
            this.name3.Name = "name3";
            this.name3.Size = new System.Drawing.Size(100, 19);
            this.name3.TabIndex = 21;
            this.name3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(293, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "SCORE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(211, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "NAME";
            // 
            // score1
            // 
            this.score1.Enabled = false;
            this.score1.Location = new System.Drawing.Point(293, 340);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(43, 19);
            this.score1.TabIndex = 24;
            this.score1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // score2
            // 
            this.score2.Enabled = false;
            this.score2.Location = new System.Drawing.Point(293, 365);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(43, 19);
            this.score2.TabIndex = 25;
            this.score2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // score3
            // 
            this.score3.Enabled = false;
            this.score3.Location = new System.Drawing.Point(293, 390);
            this.score3.Name = "score3";
            this.score3.Size = new System.Drawing.Size(43, 19);
            this.score3.TabIndex = 26;
            this.score3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(517, 506);
            this.Controls.Add(this.score3);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.name3);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Explain2);
            this.Controls.Add(this.Explain1);
            this.Controls.Add(this.gameDesigner);
            this.Controls.Add(this.endText2);
            this.Controls.Add(this.endText1);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.flappybird);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappybird;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label endText1;
        private System.Windows.Forms.Label endText2;
        private System.Windows.Forms.Label gameDesigner;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label Explain1;
        private System.Windows.Forms.Label Explain2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox scoreText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.TextBox name2;
        private System.Windows.Forms.TextBox name3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox score1;
        private System.Windows.Forms.TextBox score2;
        private System.Windows.Forms.TextBox score3;
    }
}

