namespace CF_CHash_Dictionary
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
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.cmdOpenOutputFile = new System.Windows.Forms.Button();
            this.txtoutputfile = new System.Windows.Forms.TextBox();
            this.txtSourceCodefile = new System.Windows.Forms.TextBox();
            this.cmdOpenSourceCode = new System.Windows.Forms.Button();
            this.lstDictionaryConst_inSourceCode = new System.Windows.Forms.ListView();
            this.lstnewwords_inSourceCode = new System.Windows.Forms.ListView();
            this.cmdlabel = new System.Windows.Forms.Button();
            this.cmdUnlabel = new System.Windows.Forms.Button();
            this.cmdclear = new System.Windows.Forms.Button();
            this.lstDicsNewWords = new System.Windows.Forms.ListView();
            this.cmdWriteDictionary = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.lstDictionaryConst = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.lstlabel = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // performanceCounter1
            // 
            this.performanceCounter1.CategoryName = "Processor";
            this.performanceCounter1.CounterName = "% Processor Time";
            this.performanceCounter1.InstanceName = "_Total";
            // 
            // cmdOpenOutputFile
            // 
            this.cmdOpenOutputFile.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cmdOpenOutputFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdOpenOutputFile.Location = new System.Drawing.Point(49, 3);
            this.cmdOpenOutputFile.Margin = new System.Windows.Forms.Padding(2);
            this.cmdOpenOutputFile.Name = "cmdOpenOutputFile";
            this.cmdOpenOutputFile.Size = new System.Drawing.Size(145, 31);
            this.cmdOpenOutputFile.TabIndex = 0;
            this.cmdOpenOutputFile.Text = "Open Dictionary";
            this.cmdOpenOutputFile.UseVisualStyleBackColor = false;
            this.cmdOpenOutputFile.Click += new System.EventHandler(this.cmdOpenOutputFile_Click);
            // 
            // txtoutputfile
            // 
            this.txtoutputfile.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtoutputfile.Location = new System.Drawing.Point(235, 23);
            this.txtoutputfile.Margin = new System.Windows.Forms.Padding(2);
            this.txtoutputfile.Name = "txtoutputfile";
            this.txtoutputfile.Size = new System.Drawing.Size(467, 20);
            this.txtoutputfile.TabIndex = 2;
            // 
            // txtSourceCodefile
            // 
            this.txtSourceCodefile.Location = new System.Drawing.Point(235, 67);
            this.txtSourceCodefile.Margin = new System.Windows.Forms.Padding(2);
            this.txtSourceCodefile.Name = "txtSourceCodefile";
            this.txtSourceCodefile.Size = new System.Drawing.Size(465, 20);
            this.txtSourceCodefile.TabIndex = 4;
            // 
            // cmdOpenSourceCode
            // 
            this.cmdOpenSourceCode.Location = new System.Drawing.Point(49, 46);
            this.cmdOpenSourceCode.Margin = new System.Windows.Forms.Padding(2);
            this.cmdOpenSourceCode.Name = "cmdOpenSourceCode";
            this.cmdOpenSourceCode.Size = new System.Drawing.Size(145, 38);
            this.cmdOpenSourceCode.TabIndex = 3;
            this.cmdOpenSourceCode.Text = "Open Source Code";
            this.cmdOpenSourceCode.UseVisualStyleBackColor = true;
            this.cmdOpenSourceCode.Click += new System.EventHandler(this.cmdOpenSourceCode_Click);
            // 
            // lstDictionaryConst_inSourceCode
            // 
            this.lstDictionaryConst_inSourceCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDictionaryConst_inSourceCode.HideSelection = false;
            this.lstDictionaryConst_inSourceCode.Location = new System.Drawing.Point(337, 48);
            this.lstDictionaryConst_inSourceCode.Margin = new System.Windows.Forms.Padding(2);
            this.lstDictionaryConst_inSourceCode.Name = "lstDictionaryConst_inSourceCode";
            this.lstDictionaryConst_inSourceCode.Size = new System.Drawing.Size(325, 732);
            this.lstDictionaryConst_inSourceCode.TabIndex = 6;
            this.lstDictionaryConst_inSourceCode.UseCompatibleStateImageBehavior = false;
            // 
            // lstnewwords_inSourceCode
            // 
            this.lstnewwords_inSourceCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstnewwords_inSourceCode.FullRowSelect = true;
            this.lstnewwords_inSourceCode.HideSelection = false;
            this.lstnewwords_inSourceCode.Location = new System.Drawing.Point(669, 48);
            this.lstnewwords_inSourceCode.Margin = new System.Windows.Forms.Padding(2);
            this.lstnewwords_inSourceCode.MultiSelect = false;
            this.lstnewwords_inSourceCode.Name = "lstnewwords_inSourceCode";
            this.lstnewwords_inSourceCode.Size = new System.Drawing.Size(325, 732);
            this.lstnewwords_inSourceCode.TabIndex = 7;
            this.lstnewwords_inSourceCode.UseCompatibleStateImageBehavior = false;
            // 
            // cmdlabel
            // 
            this.cmdlabel.Location = new System.Drawing.Point(3, 19);
            this.cmdlabel.Margin = new System.Windows.Forms.Padding(2);
            this.cmdlabel.Name = "cmdlabel";
            this.cmdlabel.Size = new System.Drawing.Size(78, 29);
            this.cmdlabel.TabIndex = 8;
            this.cmdlabel.Text = "Label";
            this.cmdlabel.UseVisualStyleBackColor = true;
            this.cmdlabel.Click += new System.EventHandler(this.cmdlabel_Click);
            // 
            // cmdUnlabel
            // 
            this.cmdUnlabel.Location = new System.Drawing.Point(3, 99);
            this.cmdUnlabel.Margin = new System.Windows.Forms.Padding(2);
            this.cmdUnlabel.Name = "cmdUnlabel";
            this.cmdUnlabel.Size = new System.Drawing.Size(78, 29);
            this.cmdUnlabel.TabIndex = 9;
            this.cmdUnlabel.Text = "UnLabel";
            this.cmdUnlabel.UseVisualStyleBackColor = true;
            this.cmdUnlabel.Click += new System.EventHandler(this.cmdUnlabel_Click);
            // 
            // cmdclear
            // 
            this.cmdclear.Location = new System.Drawing.Point(3, 174);
            this.cmdclear.Margin = new System.Windows.Forms.Padding(2);
            this.cmdclear.Name = "cmdclear";
            this.cmdclear.Size = new System.Drawing.Size(78, 29);
            this.cmdclear.TabIndex = 10;
            this.cmdclear.Text = "Clear";
            this.cmdclear.UseVisualStyleBackColor = true;
            this.cmdclear.Click += new System.EventHandler(this.cmdclear_Click);
            // 
            // lstDicsNewWords
            // 
            this.lstDicsNewWords.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstDicsNewWords.FullRowSelect = true;
            this.lstDicsNewWords.HideSelection = false;
            this.lstDicsNewWords.Location = new System.Drawing.Point(1439, 48);
            this.lstDicsNewWords.Margin = new System.Windows.Forms.Padding(2);
            this.lstDicsNewWords.Name = "lstDicsNewWords";
            this.lstDicsNewWords.Size = new System.Drawing.Size(365, 732);
            this.lstDicsNewWords.TabIndex = 11;
            this.lstDicsNewWords.UseCompatibleStateImageBehavior = false;
            this.lstDicsNewWords.SelectedIndexChanged += new System.EventHandler(this.lstDicsNewWords_SelectedIndexChanged);
            // 
            // cmdWriteDictionary
            // 
            this.cmdWriteDictionary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdWriteDictionary.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdWriteDictionary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdWriteDictionary.Location = new System.Drawing.Point(1523, 1019);
            this.cmdWriteDictionary.Margin = new System.Windows.Forms.Padding(2);
            this.cmdWriteDictionary.Name = "cmdWriteDictionary";
            this.cmdWriteDictionary.Size = new System.Drawing.Size(145, 32);
            this.cmdWriteDictionary.TabIndex = 12;
            this.cmdWriteDictionary.Text = "Write Dictionary ";
            this.cmdWriteDictionary.UseVisualStyleBackColor = false;
            this.cmdWriteDictionary.Click += new System.EventHandler(this.cmdWriteDictionary_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmdOpenOutputFile);
            this.panel1.Controls.Add(this.cmdOpenSourceCode);
            this.panel1.Controls.Add(this.txtSourceCodefile);
            this.panel1.Controls.Add(this.txtoutputfile);
            this.panel1.Location = new System.Drawing.Point(75, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1805, 105);
            this.panel1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(235, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dictionary Path and File";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Source Code Path and File";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Existing Dictionary";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.798915F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.44222F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstDictionaryConst, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lstDictionaryConst_inSourceCode, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstnewwords_inSourceCode, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lstlabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lstDicsNewWords, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 4, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(187, 221);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 736F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1809, 785);
            this.tableLayoutPanel1.TabIndex = 14;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(669, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 40);
            this.label4.TabIndex = 10;
            this.label4.Text = "Source code - New words";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstDictionaryConst
            // 
            this.lstDictionaryConst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDictionaryConst.HideSelection = false;
            this.lstDictionaryConst.Location = new System.Drawing.Point(5, 48);
            this.lstDictionaryConst.Margin = new System.Windows.Forms.Padding(2);
            this.lstDictionaryConst.Name = "lstDictionaryConst";
            this.lstDictionaryConst.Size = new System.Drawing.Size(325, 732);
            this.lstDictionaryConst.TabIndex = 5;
            this.lstDictionaryConst.UseCompatibleStateImageBehavior = false;
            this.lstDictionaryConst.View = System.Windows.Forms.View.Details;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1001, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(325, 40);
            this.label6.TabIndex = 11;
            this.label6.Text = "Labels ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lstlabel
            // 
            this.lstlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstlabel.FullRowSelect = true;
            this.lstlabel.HideSelection = false;
            this.lstlabel.Location = new System.Drawing.Point(1001, 48);
            this.lstlabel.Margin = new System.Windows.Forms.Padding(2);
            this.lstlabel.MultiSelect = false;
            this.lstlabel.Name = "lstlabel";
            this.lstlabel.Size = new System.Drawing.Size(325, 732);
            this.lstlabel.TabIndex = 8;
            this.lstlabel.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1439, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(365, 40);
            this.label7.TabIndex = 16;
            this.label7.Text = "New Words - Add to Dictionary";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 40);
            this.label3.TabIndex = 9;
            this.label3.Text = "Source Code - Words found in Dictionary";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdlabel);
            this.panel2.Controls.Add(this.cmdUnlabel);
            this.panel2.Controls.Add(this.cmdclear);
            this.panel2.Location = new System.Drawing.Point(1333, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 227);
            this.panel2.TabIndex = 15;
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdClose.Location = new System.Drawing.Point(1789, 1005);
            this.cmdClose.Margin = new System.Windows.Forms.Padding(2);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(145, 32);
            this.cmdClose.TabIndex = 15;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(2132, 1057);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdWriteDictionary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Manage Dictionary";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.Button cmdOpenOutputFile;
        private System.Windows.Forms.TextBox txtoutputfile;
        private System.Windows.Forms.TextBox txtSourceCodefile;
        private System.Windows.Forms.Button cmdOpenSourceCode;
        private System.Windows.Forms.ListView lstDictionaryConst_inSourceCode;
        private System.Windows.Forms.ListView lstnewwords_inSourceCode;
        private System.Windows.Forms.Button cmdlabel;
        private System.Windows.Forms.Button cmdUnlabel;
        private System.Windows.Forms.Button cmdclear;
        private System.Windows.Forms.ListView lstDicsNewWords;
        private System.Windows.Forms.Button cmdWriteDictionary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lstlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstDictionaryConst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdClose;
    }
}

