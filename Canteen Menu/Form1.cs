using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canteen_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //all these button and stuff are hidden on form//
            grpMorningTea.Visible = false;
            grpLunch.Visible = false;
            grpMyOrder.Visible = false;
            btnOrder.Visible = false;
            btnIExit.Visible = false;
            btnReset.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //When the textbox is not filled , it'll show an error message//
            if (txtName.Text == "" || txtClass.Text == "")
            {
                MessageBox.Show("Please Enter Your Name Or Tutor Class Again", "Message");
            }
            //If it's filled, it would move to show selection option//
            else
            {
                grpSignIn.Visible = false;
                grpMorningTea.Visible = true;
                grpLunch.Visible = true;
                grpMorningTea.Enabled = false;
                grpLunch.Enabled = false;

            }

        }
        private void btnMorningTea_Click(object sender, EventArgs e)
        {
            grpMorningTea.Enabled = true;
            grpLunch.Enabled = false;
            btnOrder.Visible = true;
            grpMyOrder.Visible = true;
            btnIExit.Visible = true;
            btnReset.Visible = true;
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            grpLunch.Enabled = true;
            grpMorningTea.Enabled = false;
            grpMyOrder.Visible = true;
            btnOrder.Visible = true;
            btnIExit.Visible = true;
            btnReset.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            grpMorningTea.Visible = false;
            grpLunch.Visible = false;
            grpMyOrder.Visible = false;
            btnOrder.Visible = false;
            btnReset.Visible = false;
            btnIExit.Visible = false;
            grpSignIn.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this code is used to exit from main menu//
            DialogResult iexit;
            iexit = MessageBox.Show("Confirm you want to exit?", "Ordering System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iexit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void grpMorningTea_Enter(object sender, EventArgs e)
        {
            grpMorningTea.Visible = true;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //this is for to show name who has ordered//
            string StudentName = txtName.Text;
            string tutorlass = txtClass.Text;
            lblName.Text = "Name: " + StudentName + "\r\n" + "Class: " + tutorlass;

            //all this stuuf if you add the items,so it increase and decrase the total//

            //Morning Tea Menu//
            double sum = 0;
            if (chkboxCheeseRolls.Checked == true)
                sum += 4;
            if(chkboxSavouryPinwheel.Checked==true)
                sum += 3;
            if (chkboxCinnamonSwirl.Checked == true)
                sum += 3;
            if (chkboxBrownie.Checked == true)
                sum += 3;
            if (chkboxCheesePuffs.Checked == true)
                sum += 3;
            if (radbtnSweetMuffin.Checked == true)
                sum += 3;
            if (radbtnSavouryMuffin.Checked == true)
                sum += 3;
            if (radbtnBeefSanwich.Checked == true)
                sum += 4;
            if (radbtnHamSandwich.Checked == true)
                sum += 4;
            if (radbtnBaconSandwich.Checked == true)
                sum += 4;
            if (radbtnVegetarianSanwich.Checked == true)
                sum += 4;
            if (radbtnChickenSandwich.Checked == true)
                sum += 4;
            if (radbtnSmokedSalmon.Checked == true)
                sum += 4;
            if (radbtnTomatoBagel.Checked == true)
                sum += 4;

            //Lunch Area//

            if (chkboxNuggetsWeek1.Checked == true)
                sum += 5;
            if (chkboxPumpkin.Checked == true)
                sum += 5;
            if (chkboxMacroni.Checked == true)
                sum += 5;
            if (chkbocButterChicken.Checked == true)
                sum += 5;
            if (chkbocFriedRice.Checked == true)
                sum += 5;
            if (chkboxNuggetWeek2.Checked == true)
                sum += 5;
            if (chkboxBacon.Checked == true)
                sum += 5;
            if (chkboxLasagne.Checked == true)
                sum += 5;
            if (chkboxMeatball.Checked == true)
                sum += 5;
            if (chkboxChickenBurger.Checked == true)
                sum += 5;
            if (chkboxBeefBurger.Checked == true)
                sum += 5;
            txtTotal.Text = sum.ToString("C2");

         



        }

        private void chkboxCheeseRolls_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxCheeseRolls.Checked == true)
            {
                lbItems.Items.Add(chkboxCheeseRolls.Text);
            }
            else
            {
                lbItems.Items.Remove(chkboxCheeseRolls.Text);

            }
        }

        private void chkboxSavouryPinwheel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxSavouryPinwheel.Checked == true)
            {
                lbItems.Items.Add(chkboxSavouryPinwheel.Text);
            }
            else
            {
                lbItems.Items.Remove(chkboxSavouryPinwheel.Text);
            }

        }

        private void chkboxCinnamonSwirl_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxCinnamonSwirl.Checked == true)
            {
                lbItems.Items.Add(chkboxCinnamonSwirl.Text);
            }
            else
            {
                lbItems.Items.Remove(chkboxCinnamonSwirl.Text);
            }
        }

        private void chkboxBrownie_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxBrownie.Checked == true)
            {
                lbItems.Items.Add(chkboxBrownie.Text);
            }
            else
            {
                lbItems.Items.Remove(chkboxBrownie.Text);
            }
        }

        private void chkboxCheesePuffs_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxCheesePuffs.Checked == true)
            {
                lbItems.Items.Add(chkboxCheesePuffs.Text);
            }
            else
            {
                lbItems.Items.Remove(chkboxCheesePuffs.Text);

            }
        }

        private void radbtnMuffonNone_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnMuffinNone.Checked == true)
            {
                lbItems.Items.Remove(radbtnMuffinNone.Text);
            }
        }

        private void radbtnSweetMuffin_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnSweetMuffin.Checked == true)
            {
                lbItems.Items.Add(radbtnSweetMuffin.Text);
            }
            else
            {
                lbItems.Items.Remove(radbtnSweetMuffin.Text);
            }
        }

        private void chkMuffins_CheckedChanged_1(object sender, EventArgs e)
        {
            //Still have to think about this....//
        }

        private void radbtnSavouryMuffin_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnSavouryMuffin.Checked == true)
            {
                lbItems.Items.Add(radbtnSavouryMuffin.Text);
            }
            else
            {
                lbItems.Items.Remove(radbtnSavouryMuffin.Text);
            }

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnSandwichNone.Checked == true)
            {
                lbItems.Items.Remove(radbtnSandwichNone.Text);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnBaconSandwich.Checked == true)
            {
                lbItems.Items.Add(radbtnBaconSandwich.Text);
            }
            else
            {
                lbItems.Items.Remove(radbtnBaconSandwich.Text);
            }
        }

        private void radbtnBeefSanwich_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnBeefSanwich.Checked == true)
            {
                lbItems.Items.Add(radbtnBeefSanwich.Text);
            }
            else
            {
                lbItems.Items.Remove(radbtnBeefSanwich.Text);
            }
        }

        private void radbtnHamSandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnHamSandwich.Checked == true)
            {
                lbItems.Items.Add(radbtnHamSandwich.Text);
            }
            else
            {
                lbItems.Items.Remove(radbtnHamSandwich.Text);
            }
        }

        private void radbtnVegetarianSanwich_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnVegetarianSanwich.Checked == true)
            {
                lbItems.Items.Add(radbtnVegetarianSanwich.Text);
            }
            else
            {
                lbItems.Items.Remove(radbtnVegetarianSanwich.Text);
            }
        }

        private void radbtnChickenSandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnChickenSandwich.Checked == true)
            {
                lbItems.Items.Add(radbtnChickenSandwich.Text);
            }
            else
            {
                lbItems.Items.Remove(radbtnChickenSandwich.Text);
            }
        }

        private void radbtnBagelsNone_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnBagelsNone.Checked == true)
            {
                lbItems.Items.Remove(radbtnBagelsNone.Text);
            }
        }

        private void radbtnSmokedSalmon_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnSmokedSalmon.Checked == true)
            {
                lbItems.Items.Add(radbtnSmokedSalmon.Text);
            }
            else
            {
                lbItems.Items.Remove(radbtnSmokedSalmon.Text);
            }
        }

        private void radbtnTomatoBagel_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnTomatoBagel.Checked == true)
            {
                lbItems.Items.Add(radbtnTomatoBagel.Text);
            }
            else
            {
                lbItems.Items.Remove(radbtnTomatoBagel.Text);
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void chkboxNuggetsWeek1_CheckedChanged(object sender, EventArgs e)
        {
            if(chkboxNuggetsWeek1.Checked==true)
            {
                lbItems.Items.Add(chkboxNuggetsWeek1.Text);
            }
            else
            {
                lbItems.Items.Remove(chkboxNuggetsWeek1.Text);
            }
        }

        private void chkboxPumpkin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxPumpkin.Checked == true)
            {
                lbItems.Items.Add(chkboxPumpkin.Text);
            }
            else
            {
                lbItems.Items.Remove(chkboxPumpkin.Text);
            }
        }

        private void chkboxMacroni_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxMacroni.Checked == true)
            {
                lbItems.Items.Add(chkboxMacroni.Text);
            }
            else
            {
                lbItems.Items.Remove(chkboxMacroni.Text);
            }
        }

        private void chkbocButterChicken_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbocButterChicken.Checked == true)
            {
                lbItems.Items.Add(chkbocButterChicken.Text);
            }
            else
            {
                lbItems.Items.Remove(chkbocButterChicken.Text);
            }

        }

        private void chkbocFriedRice_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbocFriedRice.Checked == true)
            {
                lbItems.Items.Add(chkbocFriedRice.Text);
            }
            else
            {
                lbItems.Items.Remove(chkbocFriedRice.Text);
            }
        }

        private void chkboxNuggetWeek2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxNuggetWeek2.Checked == true)
            {
                lbItems.Items.Add(chkboxNuggetWeek2.Text);
            }
            else
            {
                lbItems.Items.Remove(chkboxNuggetWeek2.Text);
            }
        }

        private void chkboxBacon_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxBacon.Checked == true)
            {
                lbItems.Items.Add(chkboxBacon.Text);
            }
            else
            {
                lbItems.Items.Remove(chkboxBacon.Text);
            }
        }

        private void chkboxLasagne_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxLasagne.Checked == true)
            {
                lbItems.Items.Add(chkboxLasagne.Text);
            }
            else
            {
                lbItems.Items.Remove(chkboxLasagne.Text);
            }
        }

        private void chkboxMeatball_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxMeatball.Checked == true)
            {
                lbItems.Items.Add(chkboxMeatball.Text);
            }
            else
            {
                lbItems.Items.Remove(chkboxMeatball.Text);
            }
        }

        private void chkboxChickenBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxChickenBurger.Checked == true)
            {
                lbItems.Items.Add(chkboxChickenBurger.Text);
            }
            else
            {
                lbItems.Items.Remove(chkboxChickenBurger.Text);
            }
        }

        private void chkboxBeefBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxBeefBurger.Checked == true)
            {
                lbItems.Items.Add(chkboxBeefBurger.Text);
            }
            else
            {
                lbItems.Items.Remove(chkboxBeefBurger.Text);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //given below actions will be taken if we click this button//
            ResetCheckboxes();
            txtTotal.Clear();
            ResetRadiobutton();
            grpMorningTea.Enabled = false;
            grpLunch.Enabled = false;
            
        }
        private void ResetCheckboxes()
        {
            //this is for to reset all checkboxes//
            Action<Control.ControlCollection> funct = null;

            funct = (controls) =>
              {
                  foreach (Control control in controls)
                      if (control is CheckBox)
                          (control as CheckBox).Checked = false;
                      else
                          funct(control.Controls);

              };
            funct(Controls);
        }
        private void ResetRadiobutton()
        {
            //this is for reset all radiobuttons//
            Action<Control.ControlCollection> funct = null;

            funct = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is RadioButton)
                        (control as RadioButton).Checked = false;
                    else
                        funct(control.Controls);

            };
            funct(Controls);
        }

            private void btnIExit_Click(object sender, EventArgs e)
        {
            //this code is used to exit from main menu//
            DialogResult iexit;
            iexit = MessageBox.Show("Confirm you want to exit?", "Ordering System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iexit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
