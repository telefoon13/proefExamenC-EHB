namespace Examen_Voorbeeld
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lbPath = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tbValidationResults = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.gbHelp = new System.Windows.Forms.GroupBox();
            this.lbHelp = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.gbHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(229, 90);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(881, 28);
            this.progressBar1.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(8, 43);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnImport
            // 
            this.btnImport.Enabled = false;
            this.btnImport.Location = new System.Drawing.Point(8, 90);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(100, 28);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(136, 49);
            this.lbPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(20, 17);
            this.lbPath.TabIndex = 3;
            this.lbPath.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.tbResult);
            this.groupBox1.Controls.Add(this.tbValidationResults);
            this.groupBox1.Controls.Add(this.btnValidate);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.lbPath);
            this.groupBox1.Controls.Add(this.btnImport);
            this.groupBox1.Location = new System.Drawing.Point(16, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1135, 390);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import XML";
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(116, 90);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(8, 126);
            this.tbResult.Margin = new System.Windows.Forms.Padding(4);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResult.Size = new System.Drawing.Size(1101, 89);
            this.tbResult.TabIndex = 8;
            // 
            // tbValidationResults
            // 
            this.tbValidationResults.Location = new System.Drawing.Point(8, 271);
            this.tbValidationResults.Margin = new System.Windows.Forms.Padding(4);
            this.tbValidationResults.Multiline = true;
            this.tbValidationResults.Name = "tbValidationResults";
            this.tbValidationResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbValidationResults.Size = new System.Drawing.Size(1101, 111);
            this.tbValidationResults.TabIndex = 7;
            // 
            // btnValidate
            // 
            this.btnValidate.Enabled = false;
            this.btnValidate.Location = new System.Drawing.Point(8, 235);
            this.btnValidate.Margin = new System.Windows.Forms.Padding(4);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(100, 28);
            this.btnValidate.TabIndex = 5;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // gbHelp
            // 
            this.gbHelp.Controls.Add(this.lbHelp);
            this.gbHelp.Location = new System.Drawing.Point(24, 16);
            this.gbHelp.Margin = new System.Windows.Forms.Padding(4);
            this.gbHelp.Name = "gbHelp";
            this.gbHelp.Padding = new System.Windows.Forms.Padding(4);
            this.gbHelp.Size = new System.Drawing.Size(1127, 80);
            this.gbHelp.TabIndex = 6;
            this.gbHelp.TabStop = false;
            this.gbHelp.Text = "Werking van de applicatie";
            // 
            // lbHelp
            // 
            this.lbHelp.AutoSize = true;
            this.lbHelp.Location = new System.Drawing.Point(9, 25);
            this.lbHelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHelp.Name = "lbHelp";
            this.lbHelp.Size = new System.Drawing.Size(625, 34);
            this.lbHelp.TabIndex = 0;
            this.lbHelp.Text = "1) Selecteer een folder via Browse. Deze folder dient XML bestanden te bevatten.\r" +
    "\n2) Start de import. Dit zal er voor zorgen dat de XML bestanden in het geheugen" +
    " worden geladen.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 527);
            this.Controls.Add(this.gbHelp);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Import XML";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbHelp.ResumeLayout(false);
            this.gbHelp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbHelp;
        private System.Windows.Forms.Label lbHelp;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TextBox tbValidationResults;
        private System.Windows.Forms.TextBox tbResult;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCancel;
    }
}

