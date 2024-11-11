namespace Tic_Tac_Toe_Project
{
    partial class frmResults
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
            this.ListView1 = new System.Windows.Forms.ListView();
            this.lviRounds = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviWinner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Loser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateOfRound = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWinnerUntilNow = new System.Windows.Forms.Label();
            this.lblXtimeWon = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblOtimeWon = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListView1
            // 
            this.ListView1.BackColor = System.Drawing.Color.White;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lviRounds,
            this.lviWinner,
            this.Loser,
            this.DateOfRound});
            this.ListView1.ContextMenuStrip = this.contextMenuStrip1;
            this.ListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView1.ForeColor = System.Drawing.Color.Black;
            this.ListView1.HideSelection = false;
            this.ListView1.Location = new System.Drawing.Point(12, 12);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(529, 334);
            this.ListView1.TabIndex = 14;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // lviRounds
            // 
            this.lviRounds.Text = "Rounds";
            this.lviRounds.Width = 100;
            // 
            // lviWinner
            // 
            this.lviWinner.Text = "Winner";
            this.lviWinner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lviWinner.Width = 100;
            // 
            // Loser
            // 
            this.Loser.Text = "Loser";
            this.Loser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Loser.Width = 100;
            // 
            // DateOfRound
            // 
            this.DateOfRound.Text = "Date Of The Round";
            this.DateOfRound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateOfRound.Width = 225;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(586, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 73);
            this.label1.TabIndex = 15;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(586, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 73);
            this.label2.TabIndex = 16;
            this.label2.Text = "O:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(549, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "The Winner Until Now Is:";
            // 
            // lblWinnerUntilNow
            // 
            this.lblWinnerUntilNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnerUntilNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblWinnerUntilNow.Location = new System.Drawing.Point(607, 239);
            this.lblWinnerUntilNow.Name = "lblWinnerUntilNow";
            this.lblWinnerUntilNow.Size = new System.Drawing.Size(133, 74);
            this.lblWinnerUntilNow.TabIndex = 18;
            this.lblWinnerUntilNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblXtimeWon
            // 
            this.lblXtimeWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXtimeWon.ForeColor = System.Drawing.Color.Yellow;
            this.lblXtimeWon.Location = new System.Drawing.Point(684, 25);
            this.lblXtimeWon.Name = "lblXtimeWon";
            this.lblXtimeWon.Size = new System.Drawing.Size(105, 63);
            this.lblXtimeWon.TabIndex = 19;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnClose.Location = new System.Drawing.Point(651, 384);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 54);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(28, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 54);
            this.button1.TabIndex = 22;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOtimeWon
            // 
            this.lblOtimeWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtimeWon.ForeColor = System.Drawing.Color.Red;
            this.lblOtimeWon.Location = new System.Drawing.Point(684, 112);
            this.lblOtimeWon.Name = "lblOtimeWon";
            this.lblOtimeWon.Size = new System.Drawing.Size(105, 63);
            this.lblOtimeWon.TabIndex = 23;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(102, 26);
            // 
            // delteToolStripMenuItem
            // 
            this.delteToolStripMenuItem.Name = "delteToolStripMenuItem";
            this.delteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.delteToolStripMenuItem.Text = "Delte";
            this.delteToolStripMenuItem.Click += new System.EventHandler(this.delteToolStripMenuItem_Click);
            // 
            // frmResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOtimeWon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblXtimeWon);
            this.Controls.Add(this.lblWinnerUntilNow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListView1);
            this.Name = "frmResults";
            this.Text = "Results";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWinnerUntilNow;
        private System.Windows.Forms.Label lblXtimeWon;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblOtimeWon;
        public System.Windows.Forms.ListView ListView1;
        public System.Windows.Forms.ColumnHeader lviRounds;
        public System.Windows.Forms.ColumnHeader lviWinner;
        public System.Windows.Forms.ColumnHeader Loser;
        public System.Windows.Forms.ColumnHeader DateOfRound;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem delteToolStripMenuItem;
    }
}