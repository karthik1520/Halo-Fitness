/* Student Name: Karthik Mahadevan Ramesh Kumar
 * Student ID: 23101941
 * Date:15/10/2023
 * Assignment: 2
 * Assignment: Create an application for Halo Fitness
 */

/* Halo Fitness
 * This application is designed to calculate the Fares for Halo Fitness Program
 * The applpication enables users to select the programs and sessions along with discounts.
 * It enables users to choose for upgrades along with a customized Water Bottles.
 * The application allows the users to view the summary along with booking details
 */

namespace HaloFitnessAssignment
{
    public partial class HaloFitnessForm : Form
    {
        public HaloFitnessForm()
        {
            InitializeComponent();
        }
        // Initializing Events/ Actions on load of form
        private void HaloFitnessForm_Load(object sender, EventArgs e)
        {
            BookButton.Enabled = false;
            SummaryButton.Enabled = false;
            ClearButton.Enabled = false;
            UpgradesListBox.Enabled = false;
            AttendeesTextBox.Text = "0";
            NoUpgradeRadioButton.Visible = false;

            // Setting Tool tip text
            DisplayButtonToolTip.SetToolTip(DisplayButton, "Click to display the selected programs and upgrades");
            BookButtonToolTip.SetToolTip(BookButton, "Click to book the selected programs and upgrades");
            SummaryButtonToolTip.SetToolTip(SummaryButton, "Click to display the summary data");
            ClearButtonToolTip.SetToolTip(ClearButton, "Click to clear the data and reset form");
            ExitButtonToolTip.SetToolTip(ExitButton, "Click to exit the Application");
        }
        // Decleration of Global Variables and Constant Variables
        int TotalRegistrationsForDay, TotalNoOfAttendees, SessionNumbers, NoOfAttendees,
            TotalCountOfUpgrades = 0, TotalUpgrades = 0, UpgradeIndex = 0,
            TotalBottleUpgrades = 0, CustomizedBottleUpgrades = 0;
        string Program = "";
        decimal TotalFeesCollected, ProgramFees, GroupFees;
        const string PROGRAM1 = "Circuit Training", PROGRAM2 = "Pilates", PROGRAM3 = "High-Intensity Interval Training", PROGRAM4 = "Aerobics",
        PROGRAM5 = "Fitness Boot Camp", PROGRAM6 = "Weight Training", PROGRAM7 = "Agility", PROGRAM8 = "Yoga", PROGRAM9 = "Speed Training";
        
        const string UPGRADEPROGRAM1 = "One to One Training", UPGRADEPROGRAM2 = "Small Group Training", UPGRADEPROGRAM3 = " Medium Group Training";
        const decimal PROGRAM1COST = 25m, PROGRAM2COST = 40m, PROGRAM3COST = 25m, PROGRAM4COST = 25m, PROGRAM5COST = 20m, PROGRAM6COST = 25m,
        PROGRAM7COST = 50m, PROGRAM8COST = 35m, PROGRAM9COST = 45m;

        const int NUMBEROFSESSIONSBUNDLE1 = 1, NUMBEROFSESSIONSBUNDLE2 = 3, NUMBEROFSESSIONSBUNDLE3 = 5, NUMBEROFSESSIONSBUNDLE4 = 7,
        NUMBEROFSESSIONSBUNDLE5 = 10, NUMBEROFSESSIONSBUNDLE6 = 12;

        const decimal BUNDLE1DISCOUNT = 0m, BUNDLE2DISCOUNT = .05m, BUNDLE3DISCOUNT = .10m, BUNDLE4DISCOUNT = .15m, BUNDLE5DISCOUNT = .20m,
        BUNDLE6DISCOUNT = .30m;

        const decimal ONETOONETRAININGCOST = 25m, SMALLGROUPTRAININGCOST = 15m, MEDIUMGROUPTRAININGCOST = 20m;
        const decimal GROUPDISCOUNT = .075m, PERSONALIZEDBOTTLECOST = 7.99m;
        // Event to enable Upgrade event only on mouse down event. 
        // This is done to enable the upgrade option to select one of the 3 upgrade training programs
        private void UpgradeRadioButton_MouseDown(object sender, MouseEventArgs e)
        {
            UpgradesListBox.Enabled = true;
        }
        // Selecting the values in attendance text box on mouse down event.
        // Done to Automatically select the entire value instead of hitting backspace
        private void AttendeesTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            AttendeesTextBox.Focus();
            AttendeesTextBox.SelectAll();
        }
        // Action Performed when NoUpgrade Radio button is selected
        private void NoUpgradeRadioButton_MouseDown(object sender, MouseEventArgs e)
        {
            UpgradesListBox.ClearSelected();
            UpgradesListBox.Enabled = false;
        }
        // Actions performed on click of display button
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            //  Declaring Variables and setting initial values
            int ProgramIndex = 0, SessionIndex = 0;
            decimal ProgramPrice = 0m, SessionDiscount = 0m, UpgradeFees = 0m;
            string UpgradeProgram = "";

            // Checking if the Listbox value has been selected or not.
            // If not selected then control will skip to the else block
            if ((FitnessProgramListBox.SelectedIndex != -1))
            {
                if ((PricingPerSessionListBox.SelectedIndex != -1))
                {
                    // parsing value of attendees text box from string to int and storing in a variable
                    NoOfAttendees = int.Parse(AttendeesTextBox.Text);
                    if (int.TryParse(AttendeesTextBox.Text, out NoOfAttendees) && NoOfAttendees > 0)
                    {
                        // Assigning the index values to a variable inorder to be used in switch statement
                        ProgramIndex = FitnessProgramListBox.SelectedIndex;
                        SessionIndex = PricingPerSessionListBox.SelectedIndex;
                        SummaryButton.Enabled = true;

                        // Switching between different cases/ values in listboxes
                        // Assigning Cost and program values to varaibles decalred in order to switch
                        switch (ProgramIndex)
                        {
                            case 0: Program = PROGRAM1; ProgramPrice = PROGRAM1COST; break;
                            case 1: Program = PROGRAM2; ProgramPrice = PROGRAM2COST; break;
                            case 2: Program = PROGRAM3; ProgramPrice = PROGRAM3COST; break;
                            case 3: Program = PROGRAM4; ProgramPrice = PROGRAM4COST; break;
                            case 4: Program = PROGRAM5; ProgramPrice = PROGRAM5COST; break;
                            case 5: Program = PROGRAM6; ProgramPrice = PROGRAM6COST; break;
                            case 6: Program = PROGRAM7; ProgramPrice = PROGRAM7COST; break;
                            case 7: Program = PROGRAM8; ProgramPrice = PROGRAM8COST; break;
                            case 8: Program = PROGRAM9; ProgramPrice = PROGRAM9COST; break;
                        }

                        // Switching between different sessions and discount rates
                        switch (SessionIndex)
                        {
                            case 0: SessionNumbers = NUMBEROFSESSIONSBUNDLE1; SessionDiscount = BUNDLE1DISCOUNT; break;
                            case 1: SessionNumbers = NUMBEROFSESSIONSBUNDLE2; SessionDiscount = BUNDLE2DISCOUNT; break;
                            case 2: SessionNumbers = NUMBEROFSESSIONSBUNDLE3; SessionDiscount = BUNDLE3DISCOUNT; break;
                            case 3: SessionNumbers = NUMBEROFSESSIONSBUNDLE4; SessionDiscount = BUNDLE4DISCOUNT; break;
                            case 4: SessionNumbers = NUMBEROFSESSIONSBUNDLE5; SessionDiscount = BUNDLE5DISCOUNT; break;
                            case 5: SessionNumbers = NUMBEROFSESSIONSBUNDLE6; SessionDiscount = BUNDLE6DISCOUNT; break;
                        }

                        // Condition to check if the radio button has been checked
                        // On enabling radio button, it is possible to select one of the upgrades
                        if (UpgradeRadioButton.Checked)
                        {
                            UpgradeIndex = UpgradesListBox.SelectedIndex;
                            if (UpgradeIndex != -1)
                            {
                                // Making visible the No Upgrade Radio Button
                                NoUpgradeRadioButton.Visible = true;

                                // switching between upgrade options
                                // This block also checks if there are 4 or more attendees and if an upgrade option has been selected in order to apply a group discount 
                                switch (UpgradeIndex)
                                {
                                    // Actions performed if Upgrade option 1 is selected
                                    case 0:
                                        UpgradeProgram = UPGRADEPROGRAM1; UpgradeFees = ONETOONETRAININGCOST;
                                        if (NoOfAttendees >= 4)
                                        {
                                            if (CustomizedBottleUpgradeCheckBox.Checked)
                                            {
                                                ProgramFees = (((ProgramPrice + UpgradeFees + PERSONALIZEDBOTTLECOST) - (SessionDiscount * (ProgramPrice + UpgradeFees + PERSONALIZEDBOTTLECOST))) * SessionNumbers) * NoOfAttendees;
                                                GroupFees = ProgramFees - (ProgramFees * GROUPDISCOUNT);
                                                OutputLabel.Text = "\n" + "Program: " + Program + "\n" + "\n" + "Number of Sessions: " +
                                                SessionNumbers.ToString() + "\n" + "\n" + "Selected Training Method: " + UpgradeProgram +
                                                "\n" + "\n" + "One to One Training Program Cost: " + ONETOONETRAININGCOST.ToString("C") +
                                                "\n" + "\n" + "Personalized Bottle Cost: " + PERSONALIZEDBOTTLECOST.ToString("C") +
                                                "\n" + "\n" + "Group Discount Applied: Yes" + "\n" + "\n" + "Group Discount Rate: " + GROUPDISCOUNT +
                                                "\n" + "\n" + "Total Program Fees Before Group Discount " + ProgramFees.ToString("C") +
                                                "\n" + "\n" + "Total Program Fees After Group Discount " + GroupFees.ToString("C");
                                            }
                                            else
                                            {
                                                ProgramFees = (((ProgramPrice + UpgradeFees) - (SessionDiscount * (ProgramPrice + UpgradeFees))) * SessionNumbers) * NoOfAttendees;
                                                GroupFees = ProgramFees - (ProgramFees * GROUPDISCOUNT);
                                                OutputLabel.Text = "\n" + "Program: " + Program + "\n" + "\n" + "Number of Sessions: " +
                                                SessionNumbers.ToString() + "\n" + "\n" + "Selected Training Method: " + UpgradeProgram +
                                                "\n" + "\n" + "One to One Training Program Cost: " + ONETOONETRAININGCOST.ToString("C") +
                                                "\n" + "\n" + "Group Discount Applied: Yes" + "\n" + "\n" + "Group Discount Rate: " + GROUPDISCOUNT +
                                                "\n" + "\n" + "Total Program Fees Before Group Discount " + ProgramFees.ToString("C") +
                                                "\n" + "\n" + "Total Program Fees After Group Discount " + GroupFees.ToString("C");
                                            }
                                        }
                                        else
                                        {
                                            if (CustomizedBottleUpgradeCheckBox.Checked)
                                            {
                                                ProgramFees = (((ProgramPrice + UpgradeFees + PERSONALIZEDBOTTLECOST) - (SessionDiscount * (ProgramPrice + UpgradeFees + PERSONALIZEDBOTTLECOST))) * SessionNumbers) * NoOfAttendees;
                                                OutputLabel.Text = "\n" + "Program: " + Program + "\n" + "\n" + "Number of Sessions: " +
                                                SessionNumbers.ToString() + "\n" + "\n" + "Selected Training Method: " + UpgradeProgram +
                                                "\n" + "\n" + "One to One Training Program Cost: " + ONETOONETRAININGCOST.ToString("C") +
                                                "\n" + "\n" + "Personalized Bottle Cost: " + PERSONALIZEDBOTTLECOST.ToString("C") +
                                                "\n" + "\n" + "Total Program Cost: " + ProgramFees.ToString("C");
                                            }
                                            else
                                            {
                                                ProgramFees = (((ProgramPrice + UpgradeFees) - (SessionDiscount * (ProgramPrice + UpgradeFees))) * SessionNumbers) * NoOfAttendees;
                                                OutputLabel.Text = "\n" + "Program: " + Program + "\n" + "\n" + "Number of Sessions: " +
                                                SessionNumbers.ToString() + "\n" + "\n" + "Selected Training Method: " + UpgradeProgram +
                                                "\n" + "\n" + "One to One Training Program Cost: " + ONETOONETRAININGCOST.ToString("C") +
                                                "\n" + "\n" + "Total Program Cost: " + ProgramFees.ToString("C");
                                            }
                                        }
                                        break;
                                    // Actions performed if Upgrade option 2 is selected
                                    case 1:
                                        UpgradeProgram = UPGRADEPROGRAM2; UpgradeFees = SMALLGROUPTRAININGCOST;
                                        if (NoOfAttendees >= 4)
                                        {
                                            if (CustomizedBottleUpgradeCheckBox.Checked)
                                            {
                                                ProgramFees = (((ProgramPrice + UpgradeFees + PERSONALIZEDBOTTLECOST) - (SessionDiscount * (ProgramPrice + UpgradeFees + PERSONALIZEDBOTTLECOST))) * SessionNumbers) * NoOfAttendees;
                                                GroupFees = ProgramFees - (ProgramFees * GROUPDISCOUNT);
                                                OutputLabel.Text = "\n" + "Program: " + Program + "\n" + "\n" + "Number of Sessions: " +
                                                SessionNumbers.ToString() + "\n" + "\n" + "Selected Training Method: " + UpgradeProgram +
                                                "\n" + "\n" + "Small Group Program Cost: " + SMALLGROUPTRAININGCOST.ToString("C") +
                                                "\n" + "\n" + "Personalized Bottle Cost: " + PERSONALIZEDBOTTLECOST.ToString("C") +
                                                "\n" + "\n" + "Group Discount Applied: Yes" + "\n" + "\n" + "Group Discount Rate: " + GROUPDISCOUNT +
                                                "\n" + "\n" + "Total Program Fees Before Group Discount " + ProgramFees.ToString("C") +
                                                "\n" + "\n" + "Total Program Fees After Group Discount " + GroupFees.ToString("C");
                                            }
                                            else
                                            {
                                                ProgramFees = (((ProgramPrice + UpgradeFees) - (SessionDiscount * (ProgramPrice + UpgradeFees))) * SessionNumbers) * NoOfAttendees;
                                                GroupFees = ProgramFees - (ProgramFees * GROUPDISCOUNT);
                                                OutputLabel.Text = "\n" + "Program: " + Program + "\n" + "\n" + "Number of Sessions: " +
                                                SessionNumbers.ToString() + "\n" + "\n" + "Selected Training Method: " + UpgradeProgram +
                                                "\n" + "\n" + "Small Group Program Cost: " + SMALLGROUPTRAININGCOST.ToString("C") +
                                                "\n" + "\n" + "Group Discount Applied: Yes" + "\n" + "\n" + "Group Discount Rate: " + GROUPDISCOUNT +
                                                "\n" + "\n" + "Total Program Fees Before Group Discount " + ProgramFees.ToString("C") +
                                                "\n" + "\n" + "Total Program Fees After Group Discount " + GroupFees.ToString("C");
                                            }
                                        }
                                        else
                                        {
                                            if (CustomizedBottleUpgradeCheckBox.Checked)
                                            {
                                                ProgramFees = (((ProgramPrice + UpgradeFees + PERSONALIZEDBOTTLECOST) - (SessionDiscount * (ProgramPrice + UpgradeFees))) * SessionNumbers) * NoOfAttendees;
                                                OutputLabel.Text = "\n" + "Program: " + Program + "\n" + "\n" + "Number of Sessions: " +
                                                SessionNumbers.ToString() + "\n" + "\n" + "Selected Training Method: " + UpgradeProgram +
                                                "\n" + "\n" + "Small Group Program Cost: " + SMALLGROUPTRAININGCOST.ToString("C") +
                                                "\n" + "\n" + "Personalized Bottle Cost: " + PERSONALIZEDBOTTLECOST.ToString("C") +
                                                "\n" + "\n" + "Total Program Cost: " + ProgramFees.ToString("C");
                                            }
                                            else
                                            {
                                                ProgramFees = (((ProgramPrice + UpgradeFees) - (SessionDiscount * (ProgramPrice + UpgradeFees))) * SessionNumbers) * NoOfAttendees;
                                                OutputLabel.Text = "\n" + "Program: " + Program + "\n" + "\n" + "Number of Sessions: " +
                                                SessionNumbers.ToString() + "\n" + "\n" + "Selected Training Method: " + UpgradeProgram +
                                                "\n" + "\n" + "Small Group Program Cost: " + SMALLGROUPTRAININGCOST.ToString("C") +
                                                "\n" + "\n" + "Total Program Cost: " + ProgramFees.ToString("C");
                                            }
                                        }
                                        break;
                                    // Actions performed if Upgrade option 3 is selected
                                    case 2:
                                        UpgradeProgram = UPGRADEPROGRAM3; UpgradeFees = MEDIUMGROUPTRAININGCOST;
                                        if (NoOfAttendees >= 4)
                                        {
                                            if (CustomizedBottleUpgradeCheckBox.Checked)
                                            {
                                                ProgramFees = (((ProgramPrice + UpgradeFees + PERSONALIZEDBOTTLECOST) - (SessionDiscount * (ProgramPrice + UpgradeFees))) * SessionNumbers) * NoOfAttendees;
                                                GroupFees = ProgramFees - (ProgramFees * GROUPDISCOUNT);
                                                OutputLabel.Text = "\n" + "Program: " + Program + "\n" + "\n" + "Number of Sessions: " +
                                                SessionNumbers.ToString() + "\n" + "\n" + "Selected Training Method: " + UpgradeProgram +
                                                "\n" + "\n" + "Medium Group Program Cost: " + MEDIUMGROUPTRAININGCOST.ToString("C") +
                                                "\n" + "\n" + "Personalized Bottle Cost: " + PERSONALIZEDBOTTLECOST.ToString("C") +
                                                "\n" + "\n" + "Group Discount Applied: Yes" + "\n" + "\n" + "Group Discount Rate: " + GROUPDISCOUNT +
                                                "\n" + "\n" + "Total Program Fees Before Group Discount " + ProgramFees.ToString("C") +
                                                "\n" + "\n" + "Total Program Fees After Group Discount " + GroupFees.ToString("C");
                                            }
                                            else
                                            {
                                                ProgramFees = (((ProgramPrice + UpgradeFees) - (SessionDiscount * (ProgramPrice + UpgradeFees))) * SessionNumbers) * NoOfAttendees;
                                                GroupFees = ProgramFees - (ProgramFees * GROUPDISCOUNT);
                                                OutputLabel.Text = "\n" + "Program: " + Program + "\n" + "\n" + "Number of Sessions: " +
                                                SessionNumbers.ToString() + "\n" + "\n" + "Selected Training Method: " + UpgradeProgram +
                                                "\n" + "\n" + "Medium Group Program Cost: " + MEDIUMGROUPTRAININGCOST.ToString("C") +
                                                "\n" + "\n" + "Group Discount Applied: Yes" + "\n" + "\n" + "Group Discount Rate: " + GROUPDISCOUNT +
                                                "\n" + "\n" + "Total Program Fees Before Group Discount " + ProgramFees.ToString("C") +
                                                "\n" + "\n" + "Total Program Fees After Group Discount " + GroupFees.ToString("C");
                                            }
                                        }
                                        else
                                        {
                                            if (CustomizedBottleUpgradeCheckBox.Checked)
                                            {
                                                ProgramFees = (((ProgramPrice + UpgradeFees + PERSONALIZEDBOTTLECOST) - (SessionDiscount * (ProgramPrice + UpgradeFees))) * SessionNumbers) * NoOfAttendees;
                                                OutputLabel.Text = "\n" + "Program: " + Program + "\n" + "\n" + "Number of Sessions: " +
                                                SessionNumbers.ToString() + "\n" + "\n" + "Selected Training Method: " + UpgradeProgram +
                                                "\n" + "\n" + "Medium Group Program Cost: " + MEDIUMGROUPTRAININGCOST.ToString("C") +
                                                "\n" + "\n" + "Personalized Bottle Cost: " + PERSONALIZEDBOTTLECOST.ToString("C") +
                                                "\n" + "\n" + "Total Program Cost: " + ProgramFees.ToString("C");
                                            }
                                            else
                                            {
                                                ProgramFees = (((ProgramPrice + UpgradeFees) - (SessionDiscount * (ProgramPrice + UpgradeFees))) * SessionNumbers) * NoOfAttendees;
                                                OutputLabel.Text = "\n" + "Program: " + Program + "\n" + "\n" + "Number of Sessions: " +
                                                SessionNumbers.ToString() + "\n" + "\n" + "Selected Training Method: " + UpgradeProgram +
                                                "\n" + "\n" + "Medium Group Program Cost: " + MEDIUMGROUPTRAININGCOST.ToString("C") +
                                                "\n" + "\n" + "Total Program Cost: " + ProgramFees.ToString("C");
                                            }
                                        }
                                        break;
                                }
                                BookButton.Enabled = true;
                                ClearButton.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Kindly select a Training Program", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                BookButton.Enabled = false;
                                SummaryButton.Enabled = false;
                                ClearButton.Enabled = false;
                            }
                        }
                        // If no upgrades has been selected then this block is executed. This performs the caluclation of the program cost
                        else
                        {
                            // Checking if Customized Bottle upgrade has been selected and calculating the price for the bottle
                            // This is then applied along with the program fees
                            if (CustomizedBottleUpgradeCheckBox.Checked)
                            {
                                ProgramFees = (((ProgramPrice + PERSONALIZEDBOTTLECOST) - (SessionDiscount * (ProgramPrice))) * SessionNumbers) * NoOfAttendees;
                                OutputLabel.Text = "\n" + "Program: " + Program + "\n" + "\n" + "Number of Sessions: " + SessionNumbers.ToString() +
                                "\n" + "\n" + "Personalized Bottle Cost: " + PERSONALIZEDBOTTLECOST.ToString("C") +
                                "\n" + "\n" + "Total Program Cost: " + ProgramFees.ToString("C");
                            }
                            else
                            {
                                ProgramFees = (((ProgramPrice) - (SessionDiscount * (ProgramPrice))) * SessionNumbers) * NoOfAttendees;
                                OutputLabel.Text = "\n" + "Program: " + Program + "\n" + "\n" + "Number of Sessions: " +
                                SessionNumbers.ToString() + "\n" + "\n" + "Total Program Cost: " + ProgramFees.ToString("C");
                                BookButton.Enabled = true;
                                ClearButton.Enabled = true;
                            }
                        }
                    }
                    // Message box prompt to help the user to identify where the error occoured and helping them solve it
                    else
                    {
                        MessageBox.Show("Please enter a value for number of attendees", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        AttendeesTextBox.Focus();
                        BookButton.Enabled = false;
                        SummaryButton.Enabled = false;
                        ClearButton.Enabled = false;
                    }
                }
                // Message box prompt to help the user to identify where the error occoured and helping them solve it
                else
                {
                    MessageBox.Show("Please select the number of sessions", "Number of sessions is Mandatory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    BookButton.Enabled = false;
                    SummaryButton.Enabled = false;
                    ClearButton.Enabled = false;
                }
            }
            // Message box prompt to help the user to identify where the error occoured and helping them solve it
            else
            {
                MessageBox.Show("Please select the Fitness Program", "Program Selection is Mandatory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BookButton.Enabled = false;
                SummaryButton.Enabled = false;
                ClearButton.Enabled = false;
            }
        }
        // Actions to perform on click of Book Button
        // This will display all the informations of the program, session count, pricing, and if the upgrades has been opted
        private void BookButton_Click(object sender, EventArgs e)
        {
            string message;
            /* the below if condition is present in order to display even the group fees
             * if the user has selected for an upgrade and the number of attendees is greater than 4
             * then group discount is applicable. So for this purpose the below if condition is put into use
            */
            if(UpgradeRadioButton.Checked)
            {
                message = "Do you wish to go ahead with the below Program" + "\n" + "\n" +
                             "Program Type: " + Program + "\n" + "\n" + "Program Duration: " + SessionNumbers +
                             "\n" + "\n" + "Program Cost: " + GroupFees.ToString("C2");
            }
            // if no group discount, then only the program fees is dispalyed
            else
            {
                message = "Do you wish to go ahead with the below Program" + "\n" + "\n" +
                             "Program Type: " + Program + "\n" + "\n" + "Program Duration: " + SessionNumbers +
                             "\n" + "\n" + "Program Cost: " + ProgramFees;
            }
            DialogResult result = MessageBox.Show(message, "Booking Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // the below if cases are to keep track of the number of upgrades for the purpose of summary
                if (UpgradeRadioButton.Checked)
                {
                    UpgradeIndex = UpgradesListBox.SelectedIndex;
                    if (UpgradeIndex != -1)
                    {
                        TotalUpgrades++;
                    }
                }
                // the below if case is to keep track of the number of upgrades for the purpose of summary
                if (CustomizedBottleUpgradeCheckBox.Checked)
                {
                    CustomizedBottleUpgrades++;
                }
                SummaryButton.Enabled = true;

                // Calculating the total count for the day in order to display in the summary
                TotalFeesCollected += ProgramFees;
                TotalNoOfAttendees += NoOfAttendees;
                TotalCountOfUpgrades += TotalUpgrades;
                TotalBottleUpgrades += CustomizedBottleUpgrades;
                TotalRegistrationsForDay++;
            }
            else
            {

            }
        }
        // Actions performed on click of Summary Button
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = "\n" + "Total Registration For Day: " + TotalRegistrationsForDay +
                "\n" + "\n" + "Total Fees Collected: " + TotalFeesCollected.ToString("C") +
                "\n" + "\n" + "Total Attendants: " + TotalNoOfAttendees +
                "\n" + "\n" + "Total Count of Upgrades: " + TotalUpgrades +
                "\n" + "\n" + "Total Count of Customized Bottle Upgrade Request: " + TotalBottleUpgrades;

        }
        // Actions performed on click of Clear
        private void ClearButton_Click(object sender, EventArgs e)
        {
            NoUpgradeRadioButton.Visible = false;
            OutputLabel.Text = "";
            FitnessProgramListBox.SelectedIndex = -1;
            PricingPerSessionListBox.SelectedIndex = -1;
            UpgradeRadioButton.Checked = false;
            UpgradesListBox.SelectedIndex = -1;
            UpgradesListBox.Enabled = false;
            CustomizedBottleUpgradeCheckBox.Checked = false;
            AttendeesTextBox.Text = "0";
            BookButton.Enabled = false;
        }
        // Actions performed on click of Exit button
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /* This method dynamically changes the contents in the outuput listbox after the display button is clicked
         * This method is done to make sure the customer is aware of the changes that is happening before before
         * This bring clarity to the use
        */
        private void FitnessProgramListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FitnessProgramListBox.SelectedIndex != -1)
            {
                if (PricingPerSessionListBox.SelectedIndex != -1)
                {
                    if (int.TryParse(AttendeesTextBox.Text, out NoOfAttendees) && NoOfAttendees > 0)
                    {
                        DisplayButton_Click(sender, e);
                    }
                }
            }
        }
        /* This method dynamically changes the contents in the outuput listbox after the display button is clicked
         * This method is done to make sure the customer is aware of the changes that is happening before before
         * This bring clarity to the use
        */
        private void PricingPerSessionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PricingPerSessionListBox.SelectedIndex != -1)
            {
                if (int.TryParse(AttendeesTextBox.Text, out NoOfAttendees) && NoOfAttendees > 0)
                {
                    DisplayButton_Click(sender, e);
                }
            }
        }
    }
}