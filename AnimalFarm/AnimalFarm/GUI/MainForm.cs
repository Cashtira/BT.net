using AnimalFarm.BLL;
using AnimalFarm.DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalFarm
{
    public partial class MainForm : Form
    {
        private bool isOn = false;
        private Cattle cow, sheep, goat;
        private int cowNum, sheepNum, goatNum;

        public MainForm()
        {
            InitializeComponent();

            //Initialize catlle quantity
            cowNum = 0;
            sheepNum = 0;
            goatNum = 0;

            //Load cattle information
            CattleBLL.LoadCattleInformation(ref cow, "cow");
            CattleBLL.LoadCattleInformation(ref sheep, "sheep");
            CattleBLL.LoadCattleInformation(ref goat, "goat");
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            isOn = !isOn;
            
            if(isOn)
            {
                //Change UI
                buttonStart.Text = "RESET";
                buttonStart.BackColor = Color.Gray;

                //Disable input
                numericUpDownCow.Enabled = false;
                numericUpDownSheep.Enabled = false;
                numericUpDownGoat.Enabled = false;

                //Get input
                cowNum = (int)numericUpDownCow.Value;
                sheepNum = (int)numericUpDownSheep.Value;
                goatNum = (int)numericUpDownGoat.Value;

                //Fill information
                textBoxCow.Text = cowNum.ToString();
                textBoxSheep.Text = sheepNum.ToString();
                textBoxGoat.Text = goatNum.ToString();

                float cowMilk = CattleBLL.giveMilk(cow, cowNum);
                float sheepMilk = CattleBLL.giveMilk(sheep, sheepNum);
                float goatMilk = CattleBLL.giveMilk(goat, goatNum);

                textBoxMilk.Text = (cowMilk + sheepMilk + goatMilk).ToString();

                //Enable breed
                buttonBreed.Enabled = true;
            }
            else
            {
                //Change UI
                buttonStart.Text = "START";
                buttonStart.BackColor = Color.DarkSeaGreen;

                //Enable input
                numericUpDownCow.Enabled = true;
                numericUpDownSheep.Enabled = true;
                numericUpDownGoat.Enabled = true;

                //Reset value
                numericUpDownCow.Value = 0;
                numericUpDownSheep.Value = 0;
                numericUpDownGoat.Value = 0;

                cowNum = 0;
                sheepNum = 0;
                goatNum = 0;

                textBoxCow.Text = "0";
                textBoxSheep.Text = "0";
                textBoxGoat.Text = "0";

                textBoxMilk.Text = "0";

                if (!checkBoxOwner.Checked)
                    textBoxSound.Clear();
            }
        }

        private void buttonBreed_Click(object sender, EventArgs e)
        {
            //Get the number of cattle in farm
            cowNum = Convert.ToInt32(textBoxCow.Text);
            sheepNum = Convert.ToInt32(textBoxSheep.Text);
            goatNum = Convert.ToInt32(textBoxGoat.Text);

            CattleBLL.breed(cow, ref cowNum);
            CattleBLL.breed(sheep, ref sheepNum);
            CattleBLL.breed(goat, ref goatNum);

            //Give milk
            float cowMilk = CattleBLL.giveMilk(cow,cowNum);
            float sheepMilk = CattleBLL.giveMilk(sheep,sheepNum);
            float goatMilk = CattleBLL.giveMilk(goat,goatNum);

            //Update UI
            textBoxCow.Text = cowNum.ToString();
            textBoxSheep.Text = sheepNum.ToString();
            textBoxGoat.Text = goatNum.ToString();
            textBoxMilk.Text = (cowMilk +  sheepMilk + goatMilk).ToString();

            //Check for owner at farm or not to update cattle call
            if(!checkBoxOwner.Checked)
            {
                string cowCall = CattleBLL.call(cow, cowNum);
                string sheepCall = CattleBLL.call(sheep, sheepNum);
                string goatCall = CattleBLL.call(goat, goatNum);

                string call = cowCall + sheepCall + goatCall;
                textBoxSound.Text = call;
            }
        }

        private void checkBoxOwner_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxOwner.Checked)
            {
                string cowCall = CattleBLL.call(cow, cowNum);
                string sheepCall = CattleBLL.call(sheep, sheepNum);
                string goatCall = CattleBLL.call(goat, goatNum);

                string call = cowCall + sheepCall + goatCall;
                textBoxSound.Text = call;
            }
            else
                textBoxSound.Clear();
        }
    }
}
