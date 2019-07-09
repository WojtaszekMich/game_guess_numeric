namespace GraGUI
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
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupBoxLosowanie = new System.Windows.Forms.GroupBox();
            this.buttonWylosuj = new System.Windows.Forms.Button();
            this.textBoxZakresDo = new System.Windows.Forms.TextBox();
            this.labelZakresDo = new System.Windows.Forms.Label();
            this.labelZakresOd = new System.Windows.Forms.Label();
            this.textBoxZakresOd = new System.Windows.Forms.TextBox();
            this.stop = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.pickedNumber = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.response = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.NumberOfTurnsLabel = new System.Windows.Forms.Label();
            this.randomNumberLabel = new System.Windows.Forms.Label();
            this.historyBtn = new System.Windows.Forms.Button();
            this.gameBox = new System.Windows.Forms.GroupBox();
            this.finishBox = new System.Windows.Forms.GroupBox();
            this.groupBoxLosowanie.SuspendLayout();
            this.gameBox.SuspendLayout();
            this.finishBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(13, 13);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(75, 23);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // groupBoxLosowanie
            // 
            this.groupBoxLosowanie.Controls.Add(this.buttonWylosuj);
            this.groupBoxLosowanie.Controls.Add(this.textBoxZakresDo);
            this.groupBoxLosowanie.Controls.Add(this.labelZakresDo);
            this.groupBoxLosowanie.Controls.Add(this.labelZakresOd);
            this.groupBoxLosowanie.Controls.Add(this.textBoxZakresOd);
            this.groupBoxLosowanie.Location = new System.Drawing.Point(13, 52);
            this.groupBoxLosowanie.Name = "groupBoxLosowanie";
            this.groupBoxLosowanie.Size = new System.Drawing.Size(370, 90);
            this.groupBoxLosowanie.TabIndex = 1;
            this.groupBoxLosowanie.TabStop = false;
            this.groupBoxLosowanie.Text = "Losowanie";
            this.groupBoxLosowanie.Visible = false;
            // 
            // buttonWylosuj
            // 
            this.buttonWylosuj.Location = new System.Drawing.Point(148, 33);
            this.buttonWylosuj.Name = "buttonWylosuj";
            this.buttonWylosuj.Size = new System.Drawing.Size(75, 23);
            this.buttonWylosuj.TabIndex = 4;
            this.buttonWylosuj.Text = "Wylosuj";
            this.buttonWylosuj.UseVisualStyleBackColor = true;
            this.buttonWylosuj.Click += new System.EventHandler(this.buttonWylosuj_Click);
            // 
            // textBoxZakresDo
            // 
            this.textBoxZakresDo.Location = new System.Drawing.Point(69, 52);
            this.textBoxZakresDo.Name = "textBoxZakresDo";
            this.textBoxZakresDo.Size = new System.Drawing.Size(46, 20);
            this.textBoxZakresDo.TabIndex = 3;
            this.textBoxZakresDo.Text = "100";
            this.textBoxZakresDo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelZakresDo
            // 
            this.labelZakresDo.AutoSize = true;
            this.labelZakresDo.Location = new System.Drawing.Point(7, 55);
            this.labelZakresDo.Name = "labelZakresDo";
            this.labelZakresDo.Size = new System.Drawing.Size(56, 13);
            this.labelZakresDo.TabIndex = 2;
            this.labelZakresDo.Text = "zakres do:";
            // 
            // labelZakresOd
            // 
            this.labelZakresOd.AutoSize = true;
            this.labelZakresOd.Location = new System.Drawing.Point(7, 20);
            this.labelZakresOd.Name = "labelZakresOd";
            this.labelZakresOd.Size = new System.Drawing.Size(56, 13);
            this.labelZakresOd.TabIndex = 1;
            this.labelZakresOd.Text = "zakres od:";
            // 
            // textBoxZakresOd
            // 
            this.textBoxZakresOd.Location = new System.Drawing.Point(69, 17);
            this.textBoxZakresOd.Name = "textBoxZakresOd";
            this.textBoxZakresOd.Size = new System.Drawing.Size(46, 20);
            this.textBoxZakresOd.TabIndex = 0;
            this.textBoxZakresOd.Text = "1";
            this.textBoxZakresOd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(308, 13);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 2;
            this.stop.Text = "Przerwij";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(293, 16);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(52, 13);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = " 00:00:05";
            // 
            // pickedNumber
            // 
            this.pickedNumber.Location = new System.Drawing.Point(11, 31);
            this.pickedNumber.Name = "pickedNumber";
            this.pickedNumber.Size = new System.Drawing.Size(100, 20);
            this.pickedNumber.TabIndex = 5;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(149, 28);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 23);
            this.check.TabIndex = 6;
            this.check.Text = "sprawdż";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.Check_Click);
            // 
            // response
            // 
            this.response.AutoSize = true;
            this.response.Location = new System.Drawing.Point(8, 63);
            this.response.Name = "response";
            this.response.Size = new System.Drawing.Size(58, 13);
            this.response.TabIndex = 7;
            this.response.Text = "odpowiedź";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(12, 16);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(99, 13);
            this.endTimeLabel.TabIndex = 8;
            this.endTimeLabel.Text = "Całkowity czas gry:";
            // 
            // NumberOfTurnsLabel
            // 
            this.NumberOfTurnsLabel.AutoSize = true;
            this.NumberOfTurnsLabel.Location = new System.Drawing.Point(12, 43);
            this.NumberOfTurnsLabel.Name = "NumberOfTurnsLabel";
            this.NumberOfTurnsLabel.Size = new System.Drawing.Size(76, 13);
            this.NumberOfTurnsLabel.TabIndex = 9;
            this.NumberOfTurnsLabel.Text = "Liczba ruchów";
            // 
            // randomNumberLabel
            // 
            this.randomNumberLabel.AutoSize = true;
            this.randomNumberLabel.Location = new System.Drawing.Point(14, 68);
            this.randomNumberLabel.Name = "randomNumberLabel";
            this.randomNumberLabel.Size = new System.Drawing.Size(65, 13);
            this.randomNumberLabel.TabIndex = 10;
            this.randomNumberLabel.Text = "wylosowana";
            // 
            // historyBtn
            // 
            this.historyBtn.Location = new System.Drawing.Point(16, 398);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(75, 23);
            this.historyBtn.TabIndex = 11;
            this.historyBtn.Text = "Historia gry";
            this.historyBtn.UseVisualStyleBackColor = true;
            this.historyBtn.Click += new System.EventHandler(this.HistoryBtn_Click);
            // 
            // gameBox
            // 
            this.gameBox.Controls.Add(this.pickedNumber);
            this.gameBox.Controls.Add(this.check);
            this.gameBox.Controls.Add(this.timeLabel);
            this.gameBox.Controls.Add(this.response);
            this.gameBox.Location = new System.Drawing.Point(12, 148);
            this.gameBox.Name = "gameBox";
            this.gameBox.Size = new System.Drawing.Size(371, 95);
            this.gameBox.TabIndex = 5;
            this.gameBox.TabStop = false;
            this.gameBox.Text = "Liczba wylosowana. Odgadnij ją!";
            this.gameBox.Visible = false;
            // 
            // finishBox
            // 
            this.finishBox.Controls.Add(this.endTimeLabel);
            this.finishBox.Controls.Add(this.NumberOfTurnsLabel);
            this.finishBox.Controls.Add(this.randomNumberLabel);
            this.finishBox.Location = new System.Drawing.Point(12, 249);
            this.finishBox.Name = "finishBox";
            this.finishBox.Size = new System.Drawing.Size(371, 100);
            this.finishBox.TabIndex = 12;
            this.finishBox.TabStop = false;
            this.finishBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 431);
            this.Controls.Add(this.finishBox);
            this.Controls.Add(this.gameBox);
            this.Controls.Add(this.historyBtn);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.groupBoxLosowanie);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxLosowanie.ResumeLayout(false);
            this.groupBoxLosowanie.PerformLayout();
            this.gameBox.ResumeLayout(false);
            this.gameBox.PerformLayout();
            this.finishBox.ResumeLayout(false);
            this.finishBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupBoxLosowanie;
        private System.Windows.Forms.Button buttonWylosuj;
        private System.Windows.Forms.TextBox textBoxZakresDo;
        private System.Windows.Forms.Label labelZakresDo;
        private System.Windows.Forms.Label labelZakresOd;
        private System.Windows.Forms.TextBox textBoxZakresOd;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox pickedNumber;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label response;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Label NumberOfTurnsLabel;
        private System.Windows.Forms.Label randomNumberLabel;
        private System.Windows.Forms.Button historyBtn;
        private System.Windows.Forms.GroupBox gameBox;
        private System.Windows.Forms.GroupBox finishBox;
    }
}

