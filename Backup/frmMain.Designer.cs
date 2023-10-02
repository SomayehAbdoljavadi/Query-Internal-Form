namespace QueryInternalForm
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
            this.txt_Query = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.txt_PF = new System.Windows.Forms.TextBox();
            this.lbl_PF = new System.Windows.Forms.Label();
            this.lbl_IF = new System.Windows.Forms.Label();
            this.txt_IF = new System.Windows.Forms.TextBox();
            this.lbl_Query = new System.Windows.Forms.Label();
            this.btn_Q1 = new System.Windows.Forms.Button();
            this.btn_Q3 = new System.Windows.Forms.Button();
            this.btn_Q2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Query
            // 
            this.txt_Query.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_Query.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Query.Location = new System.Drawing.Point(16, 60);
            this.txt_Query.Margin = new System.Windows.Forms.Padding(7);
            this.txt_Query.Multiline = true;
            this.txt_Query.Name = "txt_Query";
            this.txt_Query.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Query.Size = new System.Drawing.Size(400, 400);
            this.txt_Query.TabIndex = 1;
            this.txt_Query.Text = "Select\r\n\r\nFrom\r\n\r\nWhere\r\n\r\nGroup By\r\n\r\nHaving\r\n\r\nOrder By\r\n";
            this.txt_Query.WordWrap = false;
            // 
            // btn
            // 
            this.btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn.Location = new System.Drawing.Point(680, 474);
            this.btn.Margin = new System.Windows.Forms.Padding(7);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(150, 30);
            this.btn.TabIndex = 0;
            this.btn.Text = "! Click Me !";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_PF
            // 
            this.txt_PF.BackColor = System.Drawing.Color.White;
            this.txt_PF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_PF.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PF.Location = new System.Drawing.Point(16, 518);
            this.txt_PF.Margin = new System.Windows.Forms.Padding(7);
            this.txt_PF.Multiline = true;
            this.txt_PF.Name = "txt_PF";
            this.txt_PF.ReadOnly = true;
            this.txt_PF.Size = new System.Drawing.Size(814, 25);
            this.txt_PF.TabIndex = 2;
            this.txt_PF.TabStop = false;
            this.txt_PF.WordWrap = false;
            // 
            // lbl_PF
            // 
            this.lbl_PF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_PF.Location = new System.Drawing.Point(16, 474);
            this.lbl_PF.Margin = new System.Windows.Forms.Padding(7);
            this.lbl_PF.Name = "lbl_PF";
            this.lbl_PF.Size = new System.Drawing.Size(150, 30);
            this.lbl_PF.TabIndex = 3;
            this.lbl_PF.Text = "Parenthesis Form";
            this.lbl_PF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_IF
            // 
            this.lbl_IF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_IF.Location = new System.Drawing.Point(430, 16);
            this.lbl_IF.Margin = new System.Windows.Forms.Padding(7);
            this.lbl_IF.Name = "lbl_IF";
            this.lbl_IF.Size = new System.Drawing.Size(400, 30);
            this.lbl_IF.TabIndex = 4;
            this.lbl_IF.Text = "Internal Form";
            this.lbl_IF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_IF
            // 
            this.txt_IF.BackColor = System.Drawing.Color.White;
            this.txt_IF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_IF.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IF.Location = new System.Drawing.Point(430, 60);
            this.txt_IF.Margin = new System.Windows.Forms.Padding(7);
            this.txt_IF.Multiline = true;
            this.txt_IF.Name = "txt_IF";
            this.txt_IF.ReadOnly = true;
            this.txt_IF.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_IF.Size = new System.Drawing.Size(400, 400);
            this.txt_IF.TabIndex = 5;
            this.txt_IF.TabStop = false;
            this.txt_IF.WordWrap = false;
            // 
            // lbl_Query
            // 
            this.lbl_Query.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Query.Location = new System.Drawing.Point(16, 16);
            this.lbl_Query.Margin = new System.Windows.Forms.Padding(7);
            this.lbl_Query.Name = "lbl_Query";
            this.lbl_Query.Size = new System.Drawing.Size(400, 30);
            this.lbl_Query.TabIndex = 6;
            this.lbl_Query.Text = "Query";
            this.lbl_Query.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Q1
            // 
            this.btn_Q1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Q1.Location = new System.Drawing.Point(19, 19);
            this.btn_Q1.Margin = new System.Windows.Forms.Padding(10, 10, 2, 10);
            this.btn_Q1.Name = "btn_Q1";
            this.btn_Q1.Size = new System.Drawing.Size(27, 24);
            this.btn_Q1.TabIndex = 7;
            this.btn_Q1.TabStop = false;
            this.btn_Q1.Text = "1";
            this.btn_Q1.UseVisualStyleBackColor = true;
            this.btn_Q1.Click += new System.EventHandler(this.btn_Q1_Click);
            // 
            // btn_Q3
            // 
            this.btn_Q3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Q3.Location = new System.Drawing.Point(81, 19);
            this.btn_Q3.Margin = new System.Windows.Forms.Padding(2, 10, 10, 10);
            this.btn_Q3.Name = "btn_Q3";
            this.btn_Q3.Size = new System.Drawing.Size(27, 24);
            this.btn_Q3.TabIndex = 8;
            this.btn_Q3.TabStop = false;
            this.btn_Q3.Text = "3";
            this.btn_Q3.UseVisualStyleBackColor = true;
            this.btn_Q3.Click += new System.EventHandler(this.btn_Q3_Click);
            // 
            // btn_Q2
            // 
            this.btn_Q2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Q2.Location = new System.Drawing.Point(50, 19);
            this.btn_Q2.Margin = new System.Windows.Forms.Padding(2, 10, 2, 10);
            this.btn_Q2.Name = "btn_Q2";
            this.btn_Q2.Size = new System.Drawing.Size(27, 24);
            this.btn_Q2.TabIndex = 9;
            this.btn_Q2.TabStop = false;
            this.btn_Q2.Text = "2";
            this.btn_Q2.UseVisualStyleBackColor = true;
            this.btn_Q2.Click += new System.EventHandler(this.btn_Q2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 559);
            this.Controls.Add(this.btn_Q2);
            this.Controls.Add(this.btn_Q3);
            this.Controls.Add(this.btn_Q1);
            this.Controls.Add(this.lbl_Query);
            this.Controls.Add(this.txt_IF);
            this.Controls.Add(this.lbl_IF);
            this.Controls.Add(this.lbl_PF);
            this.Controls.Add(this.txt_PF);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txt_Query);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Query Internal Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Query;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txt_PF;
        private System.Windows.Forms.Label lbl_PF;
        private System.Windows.Forms.Label lbl_IF;
        private System.Windows.Forms.TextBox txt_IF;
        private System.Windows.Forms.Label lbl_Query;
        private System.Windows.Forms.Button btn_Q1;
        private System.Windows.Forms.Button btn_Q3;
        private System.Windows.Forms.Button btn_Q2;
    }
}

