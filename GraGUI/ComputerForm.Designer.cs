namespace GraGUI
{
    partial class ComputerForm
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
            this.PickNumberBtn = new System.Windows.Forms.Button();
            this.pickedNumberInp = new System.Windows.Forms.TextBox();
            this.gameBox = new System.Windows.Forms.GroupBox();
            this.pickedNumberLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.ToBigBtn = new System.Windows.Forms.Button();
            this.WinBtn = new System.Windows.Forms.Button();
            this.TooSmallBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rangeLabel = new System.Windows.Forms.Label();
            this.HistoryBtn = new System.Windows.Forms.Button();
            this.finishBox = new System.Windows.Forms.GroupBox();
            this.finishTimeLabel = new System.Windows.Forms.Label();
            this.finishNrOftimes = new System.Windows.Forms.Label();
            this.finishPickedNr = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.gameBox.SuspendLayout();
            this.finishBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PickNumberBtn
            // 
            this.PickNumberBtn.Location = new System.Drawing.Point(353, 31);
            this.PickNumberBtn.Name = "PickNumberBtn";
            this.PickNumberBtn.Size = new System.Drawing.Size(75, 23);
            this.PickNumberBtn.TabIndex = 0;
            this.PickNumberBtn.Text = "Wybierz Numer";
            this.PickNumberBtn.UseVisualStyleBackColor = true;
            this.PickNumberBtn.Click += new System.EventHandler(this.PickNumberBtn_Click);
            // 
            // pickedNumberInp
            // 
            this.pickedNumberInp.Location = new System.Drawing.Point(12, 31);
            this.pickedNumberInp.Name = "pickedNumberInp";
            this.pickedNumberInp.Size = new System.Drawing.Size(187, 20);
            this.pickedNumberInp.TabIndex = 1;
            // 
            // gameBox
            // 
            this.gameBox.Controls.Add(this.pickedNumberLabel);
            this.gameBox.Controls.Add(this.timeLabel);
            this.gameBox.Controls.Add(this.ToBigBtn);
            this.gameBox.Controls.Add(this.WinBtn);
            this.gameBox.Controls.Add(this.TooSmallBtn);
            this.gameBox.Location = new System.Drawing.Point(12, 88);
            this.gameBox.Name = "gameBox";
            this.gameBox.Size = new System.Drawing.Size(416, 154);
            this.gameBox.TabIndex = 2;
            this.gameBox.TabStop = false;
            this.gameBox.Visible = false;
            // 
            // pickedNumberLabel
            // 
            this.pickedNumberLabel.AutoSize = true;
            this.pickedNumberLabel.Location = new System.Drawing.Point(7, 20);
            this.pickedNumberLabel.Name = "pickedNumberLabel";
            this.pickedNumberLabel.Size = new System.Drawing.Size(162, 13);
            this.pickedNumberLabel.TabIndex = 4;
            this.pickedNumberLabel.Text = "Liczba wybrana przez komputer: ";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(280, 20);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(36, 13);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Czas: ";
            // 
            // ToBigBtn
            // 
            this.ToBigBtn.Location = new System.Drawing.Point(280, 125);
            this.ToBigBtn.Name = "ToBigBtn";
            this.ToBigBtn.Size = new System.Drawing.Size(130, 23);
            this.ToBigBtn.TabIndex = 2;
            this.ToBigBtn.Text = "Za Dużo";
            this.ToBigBtn.UseVisualStyleBackColor = true;
            this.ToBigBtn.Click += new System.EventHandler(this.ToBigBtn_Click);
            // 
            // WinBtn
            // 
            this.WinBtn.Location = new System.Drawing.Point(144, 125);
            this.WinBtn.Name = "WinBtn";
            this.WinBtn.Size = new System.Drawing.Size(130, 23);
            this.WinBtn.TabIndex = 1;
            this.WinBtn.Text = "Trafione";
            this.WinBtn.UseVisualStyleBackColor = true;
            this.WinBtn.Click += new System.EventHandler(this.WinBtn_Click);
            // 
            // TooSmallBtn
            // 
            this.TooSmallBtn.Location = new System.Drawing.Point(6, 125);
            this.TooSmallBtn.Name = "TooSmallBtn";
            this.TooSmallBtn.Size = new System.Drawing.Size(132, 23);
            this.TooSmallBtn.TabIndex = 0;
            this.TooSmallBtn.Text = "Za Mało";
            this.TooSmallBtn.UseVisualStyleBackColor = true;
            this.TooSmallBtn.Click += new System.EventHandler(this.TooSmallBtn_Click);
            // 
            // rangeLabel
            // 
            this.rangeLabel.AutoSize = true;
            this.rangeLabel.Location = new System.Drawing.Point(12, 12);
            this.rangeLabel.Name = "rangeLabel";
            this.rangeLabel.Size = new System.Drawing.Size(163, 13);
            this.rangeLabel.TabIndex = 3;
            this.rangeLabel.Text = "Zakres wybrany przez komputer: ";
            this.rangeLabel.Click += new System.EventHandler(this.Label3_Click);
            // 
            // HistoryBtn
            // 
            this.HistoryBtn.Location = new System.Drawing.Point(12, 413);
            this.HistoryBtn.Name = "HistoryBtn";
            this.HistoryBtn.Size = new System.Drawing.Size(75, 23);
            this.HistoryBtn.TabIndex = 4;
            this.HistoryBtn.Text = "Historia";
            this.HistoryBtn.UseVisualStyleBackColor = true;
            this.HistoryBtn.Click += new System.EventHandler(this.HistoryBtn_Click);
            // 
            // finishBox
            // 
            this.finishBox.Controls.Add(this.finishPickedNr);
            this.finishBox.Controls.Add(this.finishNrOftimes);
            this.finishBox.Controls.Add(this.finishTimeLabel);
            this.finishBox.Location = new System.Drawing.Point(12, 260);
            this.finishBox.Name = "finishBox";
            this.finishBox.Size = new System.Drawing.Size(416, 147);
            this.finishBox.TabIndex = 5;
            this.finishBox.TabStop = false;
            this.finishBox.Visible = false;
            // 
            // finishTimeLabel
            // 
            this.finishTimeLabel.AutoSize = true;
            this.finishTimeLabel.Location = new System.Drawing.Point(10, 20);
            this.finishTimeLabel.Name = "finishTimeLabel";
            this.finishTimeLabel.Size = new System.Drawing.Size(36, 13);
            this.finishTimeLabel.TabIndex = 0;
            this.finishTimeLabel.Text = "Czas: ";
            // 
            // finishNrOftimes
            // 
            this.finishNrOftimes.AutoSize = true;
            this.finishNrOftimes.Location = new System.Drawing.Point(10, 61);
            this.finishNrOftimes.Name = "finishNrOftimes";
            this.finishNrOftimes.Size = new System.Drawing.Size(73, 13);
            this.finishNrOftimes.TabIndex = 1;
            this.finishNrOftimes.Text = "Ilość ruchów: ";
            // 
            // finishPickedNr
            // 
            this.finishPickedNr.AutoSize = true;
            this.finishPickedNr.Location = new System.Drawing.Point(10, 110);
            this.finishPickedNr.Name = "finishPickedNr";
            this.finishPickedNr.Size = new System.Drawing.Size(90, 13);
            this.finishPickedNr.TabIndex = 2;
            this.finishPickedNr.Text = "Wybrana Liczba: ";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(231, 31);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(116, 23);
            this.resetBtn.TabIndex = 6;
            this.resetBtn.Text = "Zacznij od nowa";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // ComputerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.finishBox);
            this.Controls.Add(this.HistoryBtn);
            this.Controls.Add(this.rangeLabel);
            this.Controls.Add(this.gameBox);
            this.Controls.Add(this.pickedNumberInp);
            this.Controls.Add(this.PickNumberBtn);
            this.Name = "ComputerForm";
            this.Text = "ComputerForm";
            this.gameBox.ResumeLayout(false);
            this.gameBox.PerformLayout();
            this.finishBox.ResumeLayout(false);
            this.finishBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PickNumberBtn;
        private System.Windows.Forms.TextBox pickedNumberInp;
        private System.Windows.Forms.GroupBox gameBox;
        private System.Windows.Forms.Label pickedNumberLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button ToBigBtn;
        private System.Windows.Forms.Button WinBtn;
        private System.Windows.Forms.Button TooSmallBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label rangeLabel;
        private System.Windows.Forms.Button HistoryBtn;
        private System.Windows.Forms.Label finishPickedNr;
        private System.Windows.Forms.Label finishNrOftimes;
        private System.Windows.Forms.Label finishTimeLabel;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.GroupBox finishBox;
    }
}