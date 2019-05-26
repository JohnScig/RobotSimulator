namespace ActionRobot
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdClearTiles = new System.Windows.Forms.Button();
            this.optStart = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.grdArea = new System.Windows.Forms.DataGridView();
            this.txtMoves = new System.Windows.Forms.RichTextBox();
            this.cmdRight = new System.Windows.Forms.Button();
            this.cmdUp = new System.Windows.Forms.Button();
            this.cmdLeft = new System.Windows.Forms.Button();
            this.cmdDown = new System.Windows.Forms.Button();
            this.cmdStart = new System.Windows.Forms.Button();
            this.optFinish = new System.Windows.Forms.RadioButton();
            this.optWall = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdClearMoves = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdArea)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdClearTiles
            // 
            this.cmdClearTiles.Location = new System.Drawing.Point(174, 122);
            this.cmdClearTiles.Name = "cmdClearTiles";
            this.cmdClearTiles.Size = new System.Drawing.Size(75, 23);
            this.cmdClearTiles.TabIndex = 9;
            this.cmdClearTiles.Text = "Clear tiles";
            this.cmdClearTiles.UseVisualStyleBackColor = true;
            this.cmdClearTiles.Click += new System.EventHandler(this.cmdClearTiles_Click);
            // 
            // optStart
            // 
            this.optStart.AutoSize = true;
            this.optStart.Checked = true;
            this.optStart.Location = new System.Drawing.Point(12, 125);
            this.optStart.Name = "optStart";
            this.optStart.Size = new System.Drawing.Size(47, 17);
            this.optStart.TabIndex = 6;
            this.optStart.TabStop = true;
            this.optStart.Text = "Start";
            this.optStart.UseVisualStyleBackColor = true;
            this.optStart.CheckedChanged += new System.EventHandler(this.optStart_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movement recording:";
            // 
            // grdArea
            // 
            this.grdArea.AllowUserToAddRows = false;
            this.grdArea.AllowUserToDeleteRows = false;
            this.grdArea.AllowUserToOrderColumns = true;
            this.grdArea.AllowUserToResizeColumns = false;
            this.grdArea.AllowUserToResizeRows = false;
            this.grdArea.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdArea.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdArea.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdArea.Location = new System.Drawing.Point(12, 151);
            this.grdArea.MultiSelect = false;
            this.grdArea.Name = "grdArea";
            this.grdArea.ReadOnly = true;
            this.grdArea.RowHeadersVisible = false;
            this.grdArea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdArea.Size = new System.Drawing.Size(237, 150);
            this.grdArea.TabIndex = 10;
            this.grdArea.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdArea_CellClick);
            this.grdArea.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdArea_CellFormatting);
            // 
            // txtMoves
            // 
            this.txtMoves.Location = new System.Drawing.Point(255, 9);
            this.txtMoves.Name = "txtMoves";
            this.txtMoves.ReadOnly = true;
            this.txtMoves.Size = new System.Drawing.Size(100, 292);
            this.txtMoves.TabIndex = 11;
            this.txtMoves.Text = "";
            // 
            // cmdRight
            // 
            this.cmdRight.Location = new System.Drawing.Point(174, 54);
            this.cmdRight.Name = "cmdRight";
            this.cmdRight.Size = new System.Drawing.Size(75, 23);
            this.cmdRight.TabIndex = 4;
            this.cmdRight.Text = "RIGHT";
            this.cmdRight.UseVisualStyleBackColor = true;
            this.cmdRight.Click += new System.EventHandler(this.cmdRight_Click);
            // 
            // cmdUp
            // 
            this.cmdUp.Location = new System.Drawing.Point(93, 25);
            this.cmdUp.Name = "cmdUp";
            this.cmdUp.Size = new System.Drawing.Size(75, 23);
            this.cmdUp.TabIndex = 1;
            this.cmdUp.Text = "UP";
            this.cmdUp.UseVisualStyleBackColor = true;
            this.cmdUp.Click += new System.EventHandler(this.cmdUp_Click);
            // 
            // cmdLeft
            // 
            this.cmdLeft.Location = new System.Drawing.Point(12, 54);
            this.cmdLeft.Name = "cmdLeft";
            this.cmdLeft.Size = new System.Drawing.Size(75, 23);
            this.cmdLeft.TabIndex = 2;
            this.cmdLeft.Text = "LEFT";
            this.cmdLeft.UseVisualStyleBackColor = true;
            this.cmdLeft.Click += new System.EventHandler(this.cmdLeft_Click);
            // 
            // cmdDown
            // 
            this.cmdDown.Location = new System.Drawing.Point(93, 54);
            this.cmdDown.Name = "cmdDown";
            this.cmdDown.Size = new System.Drawing.Size(75, 23);
            this.cmdDown.TabIndex = 3;
            this.cmdDown.Text = "DOWN";
            this.cmdDown.UseVisualStyleBackColor = true;
            this.cmdDown.Click += new System.EventHandler(this.cmdDown_Click);
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(12, 307);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(75, 23);
            this.cmdStart.TabIndex = 12;
            this.cmdStart.Text = "Start robot";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // optFinish
            // 
            this.optFinish.AutoSize = true;
            this.optFinish.Location = new System.Drawing.Point(117, 125);
            this.optFinish.Name = "optFinish";
            this.optFinish.Size = new System.Drawing.Size(52, 17);
            this.optFinish.TabIndex = 8;
            this.optFinish.Text = "Finish";
            this.optFinish.UseVisualStyleBackColor = true;
            this.optFinish.CheckedChanged += new System.EventHandler(this.optFinish_CheckedChanged);
            // 
            // optWall
            // 
            this.optWall.AutoSize = true;
            this.optWall.Location = new System.Drawing.Point(65, 125);
            this.optWall.Name = "optWall";
            this.optWall.Size = new System.Drawing.Size(46, 17);
            this.optWall.TabIndex = 7;
            this.optWall.Text = "Wall";
            this.optWall.UseVisualStyleBackColor = true;
            this.optWall.CheckedChanged += new System.EventHandler(this.optWall_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tiles placement:";
            // 
            // cmdClearMoves
            // 
            this.cmdClearMoves.Location = new System.Drawing.Point(255, 307);
            this.cmdClearMoves.Name = "cmdClearMoves";
            this.cmdClearMoves.Size = new System.Drawing.Size(75, 23);
            this.cmdClearMoves.TabIndex = 13;
            this.cmdClearMoves.Text = "Clear";
            this.cmdClearMoves.UseVisualStyleBackColor = true;
            this.cmdClearMoves.Click += new System.EventHandler(this.cmdClearMoves_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 341);
            this.Controls.Add(this.cmdClearMoves);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.optWall);
            this.Controls.Add(this.optFinish);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.cmdDown);
            this.Controls.Add(this.cmdLeft);
            this.Controls.Add(this.cmdUp);
            this.Controls.Add(this.cmdRight);
            this.Controls.Add(this.txtMoves);
            this.Controls.Add(this.grdArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optStart);
            this.Controls.Add(this.cmdClearTiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robot Programming";
            ((System.ComponentModel.ISupportInitialize)(this.grdArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdClearTiles;
        private System.Windows.Forms.RadioButton optStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdArea;
        private System.Windows.Forms.RichTextBox txtMoves;
        private System.Windows.Forms.Button cmdRight;
        private System.Windows.Forms.Button cmdUp;
        private System.Windows.Forms.Button cmdLeft;
        private System.Windows.Forms.Button cmdDown;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.RadioButton optFinish;
        private System.Windows.Forms.RadioButton optWall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdClearMoves;
    }
}

