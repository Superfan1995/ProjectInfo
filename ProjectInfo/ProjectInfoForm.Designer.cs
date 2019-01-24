namespace ProjectInfo
{
    partial class ProjectInfoForm
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
            this.projNameLabel = new System.Windows.Forms.Label();
            this.projNameTextBox = new System.Windows.Forms.TextBox();
            this.seperator1 = new System.Windows.Forms.Label();
            this.projTypeLabel = new System.Windows.Forms.Label();
            this.projTypeTextBox = new System.Windows.Forms.TextBox();
            this.seperator2 = new System.Windows.Forms.Label();
            this.projDesLabel = new System.Windows.Forms.Label();
            this.projDesTextBox = new System.Windows.Forms.TextBox();
            this.seperator3 = new System.Windows.Forms.Label();
            this.projUserLabel = new System.Windows.Forms.Label();
            this.projUserTextBox = new System.Windows.Forms.TextBox();
            this.seperator4 = new System.Windows.Forms.Label();
            this.projDateLabel = new System.Windows.Forms.Label();
            this.projDateTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.getDateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projNameLabel
            // 
            this.projNameLabel.AutoSize = true;
            this.projNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projNameLabel.Location = new System.Drawing.Point(12, 15);
            this.projNameLabel.Name = "projNameLabel";
            this.projNameLabel.Size = new System.Drawing.Size(90, 16);
            this.projNameLabel.TabIndex = 0;
            this.projNameLabel.Text = "Project Name";
            // 
            // projNameTextBox
            // 
            this.projNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projNameTextBox.Location = new System.Drawing.Point(114, 12);
            this.projNameTextBox.Name = "projNameTextBox";
            this.projNameTextBox.Size = new System.Drawing.Size(233, 22);
            this.projNameTextBox.TabIndex = 1;
            this.projNameTextBox.TextChanged += new System.EventHandler(this.projNameTextBox_TextChanged);
            // 
            // seperator1
            // 
            this.seperator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seperator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seperator1.Location = new System.Drawing.Point(3, 46);
            this.seperator1.Name = "seperator1";
            this.seperator1.Size = new System.Drawing.Size(351, 2);
            this.seperator1.TabIndex = 2;
            // 
            // projTypeLabel
            // 
            this.projTypeLabel.AutoSize = true;
            this.projTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projTypeLabel.Location = new System.Drawing.Point(12, 64);
            this.projTypeLabel.Name = "projTypeLabel";
            this.projTypeLabel.Size = new System.Drawing.Size(85, 16);
            this.projTypeLabel.TabIndex = 3;
            this.projTypeLabel.Text = "Project Type";
            // 
            // projTypeTextBox
            // 
            this.projTypeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projTypeTextBox.Location = new System.Drawing.Point(114, 64);
            this.projTypeTextBox.Name = "projTypeTextBox";
            this.projTypeTextBox.Size = new System.Drawing.Size(233, 22);
            this.projTypeTextBox.TabIndex = 4;
            this.projTypeTextBox.TextChanged += new System.EventHandler(this.projTypeTextBox_TextChanged);
            // 
            // seperator2
            // 
            this.seperator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seperator2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seperator2.Location = new System.Drawing.Point(3, 98);
            this.seperator2.Name = "seperator2";
            this.seperator2.Size = new System.Drawing.Size(351, 2);
            this.seperator2.TabIndex = 5;
            // 
            // projDesLabel
            // 
            this.projDesLabel.AutoSize = true;
            this.projDesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projDesLabel.Location = new System.Drawing.Point(12, 111);
            this.projDesLabel.Name = "projDesLabel";
            this.projDesLabel.Size = new System.Drawing.Size(76, 16);
            this.projDesLabel.TabIndex = 6;
            this.projDesLabel.Text = "Description";
            // 
            // projDesTextBox
            // 
            this.projDesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projDesTextBox.Location = new System.Drawing.Point(12, 141);
            this.projDesTextBox.Multiline = true;
            this.projDesTextBox.Name = "projDesTextBox";
            this.projDesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.projDesTextBox.Size = new System.Drawing.Size(334, 92);
            this.projDesTextBox.TabIndex = 7;
            this.projDesTextBox.TextChanged += new System.EventHandler(this.projDesTextBox_TextChanged);
            // 
            // seperator3
            // 
            this.seperator3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seperator3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seperator3.Location = new System.Drawing.Point(3, 248);
            this.seperator3.Name = "seperator3";
            this.seperator3.Size = new System.Drawing.Size(351, 2);
            this.seperator3.TabIndex = 8;
            // 
            // projUserLabel
            // 
            this.projUserLabel.AutoSize = true;
            this.projUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projUserLabel.Location = new System.Drawing.Point(10, 266);
            this.projUserLabel.Name = "projUserLabel";
            this.projUserLabel.Size = new System.Drawing.Size(37, 16);
            this.projUserLabel.TabIndex = 9;
            this.projUserLabel.Text = "User";
            // 
            // projUserTextBox
            // 
            this.projUserTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projUserTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projUserTextBox.Location = new System.Drawing.Point(69, 263);
            this.projUserTextBox.Name = "projUserTextBox";
            this.projUserTextBox.Size = new System.Drawing.Size(278, 22);
            this.projUserTextBox.TabIndex = 10;
            this.projUserTextBox.TextChanged += new System.EventHandler(this.projUserTextBox_TextChanged);
            // 
            // seperator4
            // 
            this.seperator4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seperator4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seperator4.Location = new System.Drawing.Point(3, 299);
            this.seperator4.Name = "seperator4";
            this.seperator4.Size = new System.Drawing.Size(351, 2);
            this.seperator4.TabIndex = 11;
            // 
            // projDateLabel
            // 
            this.projDateLabel.AutoSize = true;
            this.projDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projDateLabel.Location = new System.Drawing.Point(9, 319);
            this.projDateLabel.Name = "projDateLabel";
            this.projDateLabel.Size = new System.Drawing.Size(37, 16);
            this.projDateLabel.TabIndex = 12;
            this.projDateLabel.Text = "Date";
            // 
            // projDateTextBox
            // 
            this.projDateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projDateTextBox.Location = new System.Drawing.Point(69, 319);
            this.projDateTextBox.Name = "projDateTextBox";
            this.projDateTextBox.Size = new System.Drawing.Size(278, 22);
            this.projDateTextBox.TabIndex = 13;
            this.projDateTextBox.TextChanged += new System.EventHandler(this.projDateTextBox_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(4, 397);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 28);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(4, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 2);
            this.label1.TabIndex = 15;
            // 
            // getDateButton
            // 
            this.getDateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getDateButton.Location = new System.Drawing.Point(244, 347);
            this.getDateButton.Name = "getDateButton";
            this.getDateButton.Size = new System.Drawing.Size(102, 28);
            this.getDateButton.TabIndex = 16;
            this.getDateButton.Text = "Get Date";
            this.getDateButton.UseVisualStyleBackColor = true;
            this.getDateButton.Click += new System.EventHandler(this.getDateButton_Click);
            // 
            // ProjectInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 470);
            this.Controls.Add(this.getDateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.projDateTextBox);
            this.Controls.Add(this.projDateLabel);
            this.Controls.Add(this.seperator4);
            this.Controls.Add(this.projUserTextBox);
            this.Controls.Add(this.projUserLabel);
            this.Controls.Add(this.seperator3);
            this.Controls.Add(this.projDesTextBox);
            this.Controls.Add(this.projDesLabel);
            this.Controls.Add(this.seperator2);
            this.Controls.Add(this.projTypeTextBox);
            this.Controls.Add(this.projTypeLabel);
            this.Controls.Add(this.seperator1);
            this.Controls.Add(this.projNameTextBox);
            this.Controls.Add(this.projNameLabel);
            this.Name = "ProjectInfoForm";
            this.Text = "Project Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projNameLabel;
        private System.Windows.Forms.TextBox projNameTextBox;
        private System.Windows.Forms.Label seperator1;
        private System.Windows.Forms.Label projTypeLabel;
        private System.Windows.Forms.TextBox projTypeTextBox;
        private System.Windows.Forms.Label seperator2;
        private System.Windows.Forms.Label projDesLabel;
        private System.Windows.Forms.TextBox projDesTextBox;
        private System.Windows.Forms.Label seperator3;
        private System.Windows.Forms.Label projUserLabel;
        private System.Windows.Forms.TextBox projUserTextBox;
        private System.Windows.Forms.Label seperator4;
        private System.Windows.Forms.Label projDateLabel;
        private System.Windows.Forms.TextBox projDateTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getDateButton;
    }
}

