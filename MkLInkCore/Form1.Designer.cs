namespace MkLink
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
            txtSource = new TextBox();
            txtDestination = new TextBox();
            btnExecute = new Button();
            btnPreview = new Button();
            chkRename = new CheckBox();
            SourceLabel = new Label();
            DestinationLabel = new Label();
            browseSource = new Button();
            browseDestination = new Button();
            txtOutput = new TextBox();
            SuspendLayout();
            // 
            // txtSource
            // 
            txtSource.Location = new Point(14, 39);
            txtSource.Margin = new Padding(4, 3, 4, 3);
            txtSource.Name = "txtSource";
            txtSource.Size = new Size(507, 23);
            txtSource.TabIndex = 0;
            txtSource.TextChanged += txtSource_TextChanged;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(15, 110);
            txtDestination.Margin = new Padding(4, 3, 4, 3);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(506, 23);
            txtDestination.TabIndex = 0;
            txtDestination.TextChanged += txtDestination_TextChanged;
            // 
            // btnExecute
            // 
            btnExecute.BackColor = SystemColors.Control;
            btnExecute.Location = new Point(167, 178);
            btnExecute.Margin = new Padding(4, 3, 4, 3);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(117, 57);
            btnExecute.TabIndex = 1;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = false;
            btnExecute.Click += btnExecute_Click;
            // 
            // btnPreview
            // 
            btnPreview.BackColor = SystemColors.Control;
            btnPreview.Location = new Point(404, 178);
            btnPreview.Margin = new Padding(4, 3, 4, 3);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(117, 57);
            btnPreview.TabIndex = 1;
            btnPreview.Text = "Preview";
            btnPreview.UseVisualStyleBackColor = false;
            btnPreview.Click += btnPreview_Click;
            // 
            // chkRename
            // 
            chkRename.AutoSize = true;
            chkRename.Location = new Point(14, 140);
            chkRename.Margin = new Padding(4, 3, 4, 3);
            chkRename.Name = "chkRename";
            chkRename.Size = new Size(186, 19);
            chkRename.TabIndex = 2;
            chkRename.Text = "Rename target same as source";
            chkRename.UseVisualStyleBackColor = true;
            // 
            // SourceLabel
            // 
            SourceLabel.AutoSize = true;
            SourceLabel.Location = new Point(15, 15);
            SourceLabel.Margin = new Padding(4, 0, 4, 0);
            SourceLabel.Name = "SourceLabel";
            SourceLabel.Size = new Size(43, 15);
            SourceLabel.TabIndex = 4;
            SourceLabel.Text = "Source";
            // 
            // DestinationLabel
            // 
            DestinationLabel.AutoSize = true;
            DestinationLabel.Location = new Point(15, 91);
            DestinationLabel.Margin = new Padding(4, 0, 4, 0);
            DestinationLabel.Name = "DestinationLabel";
            DestinationLabel.Size = new Size(67, 15);
            DestinationLabel.TabIndex = 4;
            DestinationLabel.Text = "Destination";
            // 
            // browseSource
            // 
            browseSource.Location = new Point(540, 39);
            browseSource.Margin = new Padding(4, 3, 4, 3);
            browseSource.Name = "browseSource";
            browseSource.Size = new Size(88, 27);
            browseSource.TabIndex = 5;
            browseSource.Text = "Browse";
            browseSource.UseVisualStyleBackColor = true;
            browseSource.Click += browseSource_Click;
            // 
            // browseDestination
            // 
            browseDestination.Location = new Point(540, 110);
            browseDestination.Margin = new Padding(4, 3, 4, 3);
            browseDestination.Name = "browseDestination";
            browseDestination.Size = new Size(88, 27);
            browseDestination.TabIndex = 5;
            browseDestination.Text = "Browse";
            browseDestination.UseVisualStyleBackColor = true;
            browseDestination.Click += browseDestination_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(14, 252);
            txtOutput.Margin = new Padding(4, 3, 4, 3);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(614, 97);
            txtOutput.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 374);
            Controls.Add(txtOutput);
            Controls.Add(browseDestination);
            Controls.Add(browseSource);
            Controls.Add(DestinationLabel);
            Controls.Add(SourceLabel);
            Controls.Add(chkRename);
            Controls.Add(btnPreview);
            Controls.Add(btnExecute);
            Controls.Add(txtDestination);
            Controls.Add(txtSource);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MkLink GUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.CheckBox chkRename;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.Button browseSource;
        private System.Windows.Forms.Button browseDestination;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

