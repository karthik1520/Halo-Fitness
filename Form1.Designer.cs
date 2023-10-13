namespace HaloFitnessAssignment
{
    partial class HaloFitnessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HaloFitnessForm));
            ProgramDetailsPanel = new Panel();
            NoUpgradeRadioButton = new RadioButton();
            label1 = new Label();
            AttendeesLabel = new Label();
            UpgradeRadioButton = new RadioButton();
            UpgradesListBox = new ListBox();
            CustomizedBottleUpgradeCheckBox = new CheckBox();
            AttendeesTextBox = new TextBox();
            FitnessLogoPictureBox = new PictureBox();
            NumberOfSessionsLabel = new Label();
            BundleDiscountLabel = new Label();
            PricePerSessionLabel = new Label();
            ProgramLabel = new Label();
            PricingPerSessionListBox = new ListBox();
            FitnessProgramListBox = new ListBox();
            panel3 = new Panel();
            ExitButton = new Button();
            ClearButton = new Button();
            SummaryButton = new Button();
            BookButton = new Button();
            DisplayButton = new Button();
            OutputPanel = new Panel();
            OutputLabel = new Label();
            ProgramDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FitnessLogoPictureBox).BeginInit();
            panel3.SuspendLayout();
            OutputPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ProgramDetailsPanel
            // 
            ProgramDetailsPanel.Controls.Add(NoUpgradeRadioButton);
            ProgramDetailsPanel.Controls.Add(label1);
            ProgramDetailsPanel.Controls.Add(AttendeesLabel);
            ProgramDetailsPanel.Controls.Add(UpgradeRadioButton);
            ProgramDetailsPanel.Controls.Add(UpgradesListBox);
            ProgramDetailsPanel.Controls.Add(CustomizedBottleUpgradeCheckBox);
            ProgramDetailsPanel.Controls.Add(AttendeesTextBox);
            ProgramDetailsPanel.Controls.Add(FitnessLogoPictureBox);
            ProgramDetailsPanel.Controls.Add(NumberOfSessionsLabel);
            ProgramDetailsPanel.Controls.Add(BundleDiscountLabel);
            ProgramDetailsPanel.Controls.Add(PricePerSessionLabel);
            ProgramDetailsPanel.Controls.Add(ProgramLabel);
            ProgramDetailsPanel.Controls.Add(PricingPerSessionListBox);
            ProgramDetailsPanel.Controls.Add(FitnessProgramListBox);
            ProgramDetailsPanel.Location = new Point(12, 31);
            ProgramDetailsPanel.Name = "ProgramDetailsPanel";
            ProgramDetailsPanel.Size = new Size(1184, 264);
            ProgramDetailsPanel.TabIndex = 0;
            // 
            // NoUpgradeRadioButton
            // 
            NoUpgradeRadioButton.AutoSize = true;
            NoUpgradeRadioButton.Location = new Point(1028, 100);
            NoUpgradeRadioButton.Name = "NoUpgradeRadioButton";
            NoUpgradeRadioButton.Size = new Size(112, 24);
            NoUpgradeRadioButton.TabIndex = 18;
            NoUpgradeRadioButton.TabStop = true;
            NoUpgradeRadioButton.Text = "No Upgrade";
            NoUpgradeRadioButton.UseVisualStyleBackColor = true;
            NoUpgradeRadioButton.MouseDown += NoUpgradeRadioButton_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(957, 27);
            label1.Name = "label1";
            label1.Size = new Size(166, 23);
            label1.TabIndex = 17;
            label1.Text = "Upgrades Available";
            // 
            // AttendeesLabel
            // 
            AttendeesLabel.AutoSize = true;
            AttendeesLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AttendeesLabel.Location = new Point(419, 200);
            AttendeesLabel.Name = "AttendeesLabel";
            AttendeesLabel.Size = new Size(133, 20);
            AttendeesLabel.TabIndex = 16;
            AttendeesLabel.Text = "No of Attendees: ";
            // 
            // UpgradeRadioButton
            // 
            UpgradeRadioButton.AutoSize = true;
            UpgradeRadioButton.Location = new Point(925, 100);
            UpgradeRadioButton.Name = "UpgradeRadioButton";
            UpgradeRadioButton.Size = new Size(88, 24);
            UpgradeRadioButton.TabIndex = 15;
            UpgradeRadioButton.TabStop = true;
            UpgradeRadioButton.Text = "Upgrade";
            UpgradeRadioButton.UseVisualStyleBackColor = true;
            UpgradeRadioButton.MouseDown += UpgradeRadioButton_MouseDown;
            // 
            // UpgradesListBox
            // 
            UpgradesListBox.FormattingEnabled = true;
            UpgradesListBox.ItemHeight = 20;
            UpgradesListBox.Items.AddRange(new object[] { "One to One Training", "Small Group Training", "Medium Group Training" });
            UpgradesListBox.Location = new Point(925, 156);
            UpgradesListBox.Name = "UpgradesListBox";
            UpgradesListBox.Size = new Size(215, 64);
            UpgradesListBox.TabIndex = 14;
            // 
            // CustomizedBottleUpgradeCheckBox
            // 
            CustomizedBottleUpgradeCheckBox.AutoSize = true;
            CustomizedBottleUpgradeCheckBox.Location = new Point(925, 53);
            CustomizedBottleUpgradeCheckBox.Name = "CustomizedBottleUpgradeCheckBox";
            CustomizedBottleUpgradeCheckBox.Size = new Size(215, 24);
            CustomizedBottleUpgradeCheckBox.TabIndex = 9;
            CustomizedBottleUpgradeCheckBox.Text = "Customized Bottle Upgrade";
            CustomizedBottleUpgradeCheckBox.UseVisualStyleBackColor = true;
            // 
            // AttendeesTextBox
            // 
            AttendeesTextBox.Location = new Point(558, 196);
            AttendeesTextBox.Name = "AttendeesTextBox";
            AttendeesTextBox.Size = new Size(125, 27);
            AttendeesTextBox.TabIndex = 7;
            AttendeesTextBox.TextAlign = HorizontalAlignment.Center;
            AttendeesTextBox.MouseDown += AttendeesTextBox_MouseDown;
            // 
            // FitnessLogoPictureBox
            // 
            FitnessLogoPictureBox.Image = (Image)resources.GetObject("FitnessLogoPictureBox.Image");
            FitnessLogoPictureBox.Location = new Point(742, 53);
            FitnessLogoPictureBox.Name = "FitnessLogoPictureBox";
            FitnessLogoPictureBox.Size = new Size(138, 167);
            FitnessLogoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            FitnessLogoPictureBox.TabIndex = 6;
            FitnessLogoPictureBox.TabStop = false;
            // 
            // NumberOfSessionsLabel
            // 
            NumberOfSessionsLabel.AutoSize = true;
            NumberOfSessionsLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            NumberOfSessionsLabel.Location = new Point(403, 27);
            NumberOfSessionsLabel.Name = "NumberOfSessionsLabel";
            NumberOfSessionsLabel.Size = new Size(168, 23);
            NumberOfSessionsLabel.TabIndex = 5;
            NumberOfSessionsLabel.Text = "Number of Sessions";
            // 
            // BundleDiscountLabel
            // 
            BundleDiscountLabel.AutoSize = true;
            BundleDiscountLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BundleDiscountLabel.Location = new Point(585, 27);
            BundleDiscountLabel.Name = "BundleDiscountLabel";
            BundleDiscountLabel.Size = new Size(141, 23);
            BundleDiscountLabel.TabIndex = 4;
            BundleDiscountLabel.Text = "Bundle Discount";
            // 
            // PricePerSessionLabel
            // 
            PricePerSessionLabel.AutoSize = true;
            PricePerSessionLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            PricePerSessionLabel.Location = new Point(233, 27);
            PricePerSessionLabel.Name = "PricePerSessionLabel";
            PricePerSessionLabel.Size = new Size(142, 23);
            PricePerSessionLabel.TabIndex = 3;
            PricePerSessionLabel.Text = "Price Per Session";
            // 
            // ProgramLabel
            // 
            ProgramLabel.AutoSize = true;
            ProgramLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ProgramLabel.Location = new Point(24, 27);
            ProgramLabel.Name = "ProgramLabel";
            ProgramLabel.Size = new Size(85, 23);
            ProgramLabel.TabIndex = 2;
            ProgramLabel.Text = "Program ";
            // 
            // PricingPerSessionListBox
            // 
            PricingPerSessionListBox.FormattingEnabled = true;
            PricingPerSessionListBox.ItemHeight = 20;
            PricingPerSessionListBox.Items.AddRange(new object[] { "1\t\t\t        0%", "3\t\t\t        5%", "5\t\t\t      10%", "7\t              \t\t      15%", "10\t            \t\t      20%", "12\t            \t\t      30%" });
            PricingPerSessionListBox.Location = new Point(403, 53);
            PricingPerSessionListBox.Name = "PricingPerSessionListBox";
            PricingPerSessionListBox.Size = new Size(324, 124);
            PricingPerSessionListBox.TabIndex = 1;
            // 
            // FitnessProgramListBox
            // 
            FitnessProgramListBox.FormattingEnabled = true;
            FitnessProgramListBox.ItemHeight = 20;
            FitnessProgramListBox.Items.AddRange(new object[] { "Circuit Training\t\t\t₹25", "Pilates\t\t\t\t₹40", "High-intensity interval training\t₹25", "Aerobics\t\t\t\t₹25", "Fitness Boot Camp\t\t\t₹20", "Weight Training\t\t\t₹25", "Agility\t\t\t\t₹50", "Yoga\t\t\t\t₹35", "Speed Training\t\t\t₹45" });
            FitnessProgramListBox.Location = new Point(24, 53);
            FitnessProgramListBox.Name = "FitnessProgramListBox";
            FitnessProgramListBox.Size = new Size(351, 184);
            FitnessProgramListBox.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(ExitButton);
            panel3.Controls.Add(ClearButton);
            panel3.Controls.Add(SummaryButton);
            panel3.Controls.Add(BookButton);
            panel3.Controls.Add(DisplayButton);
            panel3.Location = new Point(889, 315);
            panel3.Name = "panel3";
            panel3.Size = new Size(192, 326);
            panel3.TabIndex = 2;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ExitButton.Location = new Point(48, 281);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ClearButton.Location = new Point(48, 219);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(94, 29);
            ClearButton.TabIndex = 4;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // SummaryButton
            // 
            SummaryButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SummaryButton.Location = new Point(48, 152);
            SummaryButton.Name = "SummaryButton";
            SummaryButton.Size = new Size(94, 29);
            SummaryButton.TabIndex = 3;
            SummaryButton.Text = "Summary";
            SummaryButton.UseVisualStyleBackColor = true;
            SummaryButton.Click += SummaryButton_Click;
            // 
            // BookButton
            // 
            BookButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BookButton.Location = new Point(48, 86);
            BookButton.Name = "BookButton";
            BookButton.Size = new Size(94, 29);
            BookButton.TabIndex = 2;
            BookButton.Text = "Book";
            BookButton.UseVisualStyleBackColor = true;
            BookButton.Click += BookButton_Click;
            // 
            // DisplayButton
            // 
            DisplayButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DisplayButton.Location = new Point(48, 23);
            DisplayButton.Name = "DisplayButton";
            DisplayButton.Size = new Size(94, 29);
            DisplayButton.TabIndex = 1;
            DisplayButton.Text = "Display";
            DisplayButton.UseVisualStyleBackColor = true;
            DisplayButton.Click += DisplayButton_Click;
            // 
            // OutputPanel
            // 
            OutputPanel.BackColor = SystemColors.ButtonHighlight;
            OutputPanel.Controls.Add(OutputLabel);
            OutputPanel.Location = new Point(36, 315);
            OutputPanel.Name = "OutputPanel";
            OutputPanel.Size = new Size(770, 326);
            OutputPanel.TabIndex = 3;
            // 
            // OutputLabel
            // 
            OutputLabel.AutoSize = true;
            OutputLabel.Location = new Point(12, 23);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(195, 20);
            OutputLabel.TabIndex = 0;
            OutputLabel.Text = "Selected Programs and Cost";
            // 
            // HaloFitnessForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 663);
            Controls.Add(OutputPanel);
            Controls.Add(panel3);
            Controls.Add(ProgramDetailsPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HaloFitnessForm";
            Text = "Halo Fitness Form";
            Load += HaloFitnessForm_Load;
            ProgramDetailsPanel.ResumeLayout(false);
            ProgramDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FitnessLogoPictureBox).EndInit();
            panel3.ResumeLayout(false);
            OutputPanel.ResumeLayout(false);
            OutputPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ProgramDetailsPanel;
        private ListBox PricingPerSessionListBox;
        private ListBox FitnessProgramListBox;
        private Label NumberOfSessionsLabel;
        private Label BundleDiscountLabel;
        private Label PricePerSessionLabel;
        private Label ProgramLabel;
        private TextBox AttendeesTextBox;
        private PictureBox FitnessLogoPictureBox;
        private CheckBox CustomizedBottleUpgradeCheckBox;
        private Panel panel3;
        private Button ExitButton;
        private Button ClearButton;
        private Button SummaryButton;
        private Button BookButton;
        private Button DisplayButton;
        private Panel OutputPanel;
        private Label OutputLabel;
        private RadioButton UpgradeRadioButton;
        private ListBox UpgradesListBox;
        private Label AttendeesLabel;
        private Label label1;
        private RadioButton NoUpgradeRadioButton;
    }
}