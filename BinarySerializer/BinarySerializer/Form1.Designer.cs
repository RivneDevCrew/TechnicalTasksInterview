namespace BinarySerializer
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
            this.selectInputFolderButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serializeButton = new System.Windows.Forms.Button();
            this.inputFolderTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selectOutputFolderButton = new System.Windows.Forms.Button();
            this.outputFolderTextBox = new System.Windows.Forms.TextBox();
            this.outputFileTextBox = new System.Windows.Forms.TextBox();
            this.selectOutputFileButton = new System.Windows.Forms.Button();
            this.deserializeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectInputFolderButton
            // 
            this.selectInputFolderButton.Location = new System.Drawing.Point(209, 20);
            this.selectInputFolderButton.Name = "selectInputFolderButton";
            this.selectInputFolderButton.Size = new System.Drawing.Size(46, 23);
            this.selectInputFolderButton.TabIndex = 0;
            this.selectInputFolderButton.Text = "...";
            this.selectInputFolderButton.UseVisualStyleBackColor = true;
            this.selectInputFolderButton.Click += new System.EventHandler(this.selectInputFolderButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serializeButton);
            this.groupBox1.Controls.Add(this.inputFolderTextBox);
            this.groupBox1.Controls.Add(this.selectInputFolderButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serialization";
            // 
            // serializeButton
            // 
            this.serializeButton.Location = new System.Drawing.Point(261, 20);
            this.serializeButton.Name = "serializeButton";
            this.serializeButton.Size = new System.Drawing.Size(144, 23);
            this.serializeButton.TabIndex = 2;
            this.serializeButton.Text = "Serialize";
            this.serializeButton.UseVisualStyleBackColor = true;
            this.serializeButton.Click += new System.EventHandler(this.serializeButton_Click);
            // 
            // inputFolderTextBox
            // 
            this.inputFolderTextBox.Enabled = false;
            this.inputFolderTextBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.inputFolderTextBox.Location = new System.Drawing.Point(6, 21);
            this.inputFolderTextBox.Name = "inputFolderTextBox";
            this.inputFolderTextBox.Size = new System.Drawing.Size(197, 22);
            this.inputFolderTextBox.TabIndex = 1;
            this.inputFolderTextBox.Text = "select input folder...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectOutputFolderButton);
            this.groupBox2.Controls.Add(this.outputFolderTextBox);
            this.groupBox2.Controls.Add(this.outputFileTextBox);
            this.groupBox2.Controls.Add(this.selectOutputFileButton);
            this.groupBox2.Controls.Add(this.deserializeButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 96);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deserialization";
            // 
            // selectOutputFolderButton
            // 
            this.selectOutputFolderButton.Location = new System.Drawing.Point(209, 50);
            this.selectOutputFolderButton.Name = "selectOutputFolderButton";
            this.selectOutputFolderButton.Size = new System.Drawing.Size(46, 23);
            this.selectOutputFolderButton.TabIndex = 4;
            this.selectOutputFolderButton.Text = "...";
            this.selectOutputFolderButton.UseVisualStyleBackColor = true;
            this.selectOutputFolderButton.Click += new System.EventHandler(this.selectOutputFolderButton_Click);
            // 
            // outputFolderTextBox
            // 
            this.outputFolderTextBox.Enabled = false;
            this.outputFolderTextBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.outputFolderTextBox.Location = new System.Drawing.Point(7, 50);
            this.outputFolderTextBox.Name = "outputFolderTextBox";
            this.outputFolderTextBox.Size = new System.Drawing.Size(196, 22);
            this.outputFolderTextBox.TabIndex = 3;
            this.outputFolderTextBox.Text = "select folder to unpack...";
            // 
            // outputFileTextBox
            // 
            this.outputFileTextBox.Enabled = false;
            this.outputFileTextBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.outputFileTextBox.Location = new System.Drawing.Point(7, 21);
            this.outputFileTextBox.Name = "outputFileTextBox";
            this.outputFileTextBox.Size = new System.Drawing.Size(196, 22);
            this.outputFileTextBox.TabIndex = 2;
            this.outputFileTextBox.Text = "select output file...";
            // 
            // selectOutputFileButton
            // 
            this.selectOutputFileButton.Location = new System.Drawing.Point(209, 21);
            this.selectOutputFileButton.Name = "selectOutputFileButton";
            this.selectOutputFileButton.Size = new System.Drawing.Size(46, 23);
            this.selectOutputFileButton.TabIndex = 1;
            this.selectOutputFileButton.Text = "...";
            this.selectOutputFileButton.UseVisualStyleBackColor = true;
            this.selectOutputFileButton.Click += new System.EventHandler(this.selectOutputFileButton_Click);
            // 
            // deserializeButton
            // 
            this.deserializeButton.Location = new System.Drawing.Point(261, 21);
            this.deserializeButton.Name = "deserializeButton";
            this.deserializeButton.Size = new System.Drawing.Size(144, 52);
            this.deserializeButton.TabIndex = 0;
            this.deserializeButton.Text = "Deserialize";
            this.deserializeButton.UseVisualStyleBackColor = true;
            this.deserializeButton.Click += new System.EventHandler(this.deserializeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 173);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "BinarySerializer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectInputFolderButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deserializeButton;
        private System.Windows.Forms.Button serializeButton;
        private System.Windows.Forms.TextBox inputFolderTextBox;
        private System.Windows.Forms.Button selectOutputFolderButton;
        private System.Windows.Forms.TextBox outputFolderTextBox;
        private System.Windows.Forms.TextBox outputFileTextBox;
        private System.Windows.Forms.Button selectOutputFileButton;
    }
}

