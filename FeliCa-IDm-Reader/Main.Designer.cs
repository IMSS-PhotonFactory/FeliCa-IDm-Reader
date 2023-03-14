namespace FeliCa_IDm_Reader
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxDevice = new ComboBox();
            buttonRefresh = new Button();
            label1 = new Label();
            buttonRead = new Button();
            textBoxIDm = new TextBox();
            buttonCopy = new Button();
            buttonQuit = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxDevice
            // 
            comboBoxDevice.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDevice.FormattingEnabled = true;
            comboBoxDevice.Location = new Point(148, 16);
            comboBoxDevice.Name = "comboBoxDevice";
            comboBoxDevice.Size = new Size(251, 28);
            comboBoxDevice.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            buttonRefresh.AutoSize = true;
            buttonRefresh.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRefresh.Location = new Point(405, 10);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(85, 35);
            buttonRefresh.TabIndex = 1;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 2;
            label1.Text = "Reader device";
            // 
            // buttonRead
            // 
            buttonRead.AutoSize = true;
            buttonRead.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRead.Location = new Point(39, 84);
            buttonRead.Name = "buttonRead";
            buttonRead.Size = new Size(103, 35);
            buttonRead.TabIndex = 3;
            buttonRead.Text = "Read IDm";
            buttonRead.UseVisualStyleBackColor = true;
            buttonRead.Click += buttonRead_Click;
            // 
            // textBoxIDm
            // 
            textBoxIDm.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIDm.Location = new Point(148, 80);
            textBoxIDm.Name = "textBoxIDm";
            textBoxIDm.ReadOnly = true;
            textBoxIDm.Size = new Size(251, 39);
            textBoxIDm.TabIndex = 4;
            textBoxIDm.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonCopy
            // 
            buttonCopy.AutoSize = true;
            buttonCopy.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCopy.Location = new Point(405, 84);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(85, 35);
            buttonCopy.TabIndex = 5;
            buttonCopy.Text = "Copy";
            buttonCopy.UseVisualStyleBackColor = true;
            buttonCopy.Click += buttonCopy_Click;
            // 
            // buttonQuit
            // 
            buttonQuit.AutoSize = true;
            buttonQuit.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonQuit.Location = new Point(227, 148);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Size = new Size(85, 35);
            buttonQuit.TabIndex = 6;
            buttonQuit.Text = "Quit";
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 196);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(510, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 218);
            Controls.Add(statusStrip1);
            Controls.Add(buttonQuit);
            Controls.Add(buttonCopy);
            Controls.Add(textBoxIDm);
            Controls.Add(buttonRead);
            Controls.Add(label1);
            Controls.Add(buttonRefresh);
            Controls.Add(comboBoxDevice);
            Name = "Main";
            Text = "Felica IDm Reader";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxDevice;
        private Button buttonRefresh;
        private Label label1;
        private Button buttonRead;
        private TextBox textBoxIDm;
        private Button buttonCopy;
        private Button buttonQuit;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}