namespace GraGUI
{
    partial class HistoryForm
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
            this.historyGridView = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proposition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.response = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.historyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // historyGridView
            // 
            this.historyGridView.AllowUserToAddRows = false;
            this.historyGridView.AllowUserToDeleteRows = false;
            this.historyGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.proposition,
            this.response,
            this.time});
            this.historyGridView.Location = new System.Drawing.Point(0, 1);
            this.historyGridView.Name = "historyGridView";
            this.historyGridView.ShowEditingIcon = false;
            this.historyGridView.Size = new System.Drawing.Size(512, 447);
            this.historyGridView.TabIndex = 0;
            this.historyGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HistoryGridView_CellContentClick);
            // 
            // number
            // 
            this.number.HeaderText = "Nr";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // proposition
            // 
            this.proposition.HeaderText = "Prop";
            this.proposition.Name = "proposition";
            this.proposition.ReadOnly = true;
            // 
            // response
            // 
            this.response.HeaderText = "Odp";
            this.response.Name = "response";
            this.response.ReadOnly = true;
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time.HeaderText = "Czas";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.historyGridView);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.historyGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView historyGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn proposition;
        private System.Windows.Forms.DataGridViewTextBoxColumn response;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
    }
}