using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace gusiSystemClassandObjects
{
    public class Combo
    {


        public void burgerCombo1()
        {
            Primary burger1 = new Primary();
            List<string> mainBurger = burger1.mainBurger;
            string selectedBurger = mainBurger[0];
            Secondary fries1 = new Secondary();
            List<string> sideFries = fries1.sideFries;
            string selectedFries = sideFries[0];
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Your combos are " + mainBurger[0] + " and " + sideFries[0]);
            Console.WriteLine("-----------------------------------------------------");
        }
        public void burgerCombo2()
        {
            Primary burger2 = new Primary();
            List<string> mainBurger = burger2.mainBurger;
            string selectedBurger = mainBurger[0];
            Secondary fries2 = new Secondary();
            List<string> sideFries = fries2.sideFries;
            string selectedFries = sideFries[1];
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Your combos are " + mainBurger[0] + " and " + sideFries[1]);
            Console.WriteLine("-----------------------------------------------------------");
        }
        public void burgerCombo3()
        {
            Primary burger3 = new Primary();
            List<string> mainBurger = burger3.mainBurger;
            string selectedBurger = mainBurger[1];
            Secondary fries3 = new Secondary();
            List<string> sideFries = fries3.sideFries;
            string selectedFries = sideFries[0];
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Your combos are " + mainBurger[1] + " and " + sideFries[0]);
            Console.WriteLine("----------------------------------------------");
        }
        public void burgerCombo4()
        {
            Primary burger4 = new Primary();
            List<string> mainBurger = burger4.mainBurger;
            string selectedBurger = mainBurger[1];
            Secondary fries4 = new Secondary();
            List<string> sideFries = fries4.sideFries;
            string selectedFries = sideFries[1];
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Your combos are " + mainBurger[1] + " and " + sideFries[1]);
            Console.WriteLine("----------------------------------------------------");
        }
        public void burgerCombo5()
        {
            Primary burger5 = new Primary();
            List<string> mainBurger = burger5.mainBurger;
            string selectedBurger = mainBurger[0];
            Secondary beverage1 = new Secondary();
            List<string> sidebeverage = beverage1.sideBeverage;
            string selectedBeverage = sidebeverage[0];
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Your combos are " + mainBurger[0] + " and " + sidebeverage[0]);
            Console.WriteLine("---------------------------------------------");
        }
        public void burgerCombo6()
        {
            Primary burger6 = new Primary();
            List<string> mainBurger = burger6.mainBurger;
            string selectedBurger = mainBurger[0];
            Secondary beverage2 = new Secondary();
            List<string> sidebeverage = beverage2.sideBeverage;
            string selectedBeverage = sidebeverage[1];
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Your combos is " + mainBurger[0] + " and " + sidebeverage[1]);
            Console.WriteLine("----------------------------------------------");
        }
        public void burgerCombo7()
        {
            Primary burger7 = new Primary();
            List<string> mainBurger = burger7.mainBurger;
            string selectedBurger = mainBurger[1];
            Secondary beverage3 = new Secondary();
            List<string> sidebeverage = beverage3.sideBeverage;
            string selectedBeverage = sidebeverage[0];
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Your combos are " + mainBurger[1] + " and " + sidebeverage[0]);
            Console.WriteLine("--------------------------------------");
        }
        public void burgerCombo8()
        {
            Primary burger8 = new Primary();
            List<string> mainBurger = burger8.mainBurger;
            string selectedBurger = mainBurger[1];
            Secondary beverage4 = new Secondary();
            List<string> sidebeverage = beverage4.sideBeverage;
            string selectedBeverage = sidebeverage[1];
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Your combos are " + mainBurger[1] + " and " + sidebeverage[1]);
            Console.WriteLine("---------------------------------------");
        }
        public void spaghettiCombo1()
        {
            Primary spaghetti1 = new Primary();
            List<string> mainSpaghetti = spaghetti1.mainSpaghetti;
            string selectedBurger = mainSpaghetti[0];
            Secondary friess1 = new Secondary();
            List<string> sideFries = friess1.sideFries;
            string selectedFries = sideFries[0];
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Your combos are " + mainSpaghetti[0] + " and " + sideFries[0]);
            Console.WriteLine("--------------------------------------------------");
        }
        public void spaghettiCombo2()
        {
            Primary spaghetti2 = new Primary();
            List<string> mainSpaghetti = spaghetti2.mainSpaghetti;
            string selectedBurger = mainSpaghetti[0];
            Secondary friess2 = new Secondary();
            List<string> sideFries = friess2.sideFries;
            string selectedFries = sideFries[1];
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Your combos are " + mainSpaghetti[0] + " and " + sideFries[1]);
            Console.WriteLine("--------------------------------------------------------");
        }
        public void spaghettiCombo3()
        {
            Primary spaghetti3 = new Primary();
            List<string> mainSpaghetti = spaghetti3.mainSpaghetti;
            string selectedBurger = mainSpaghetti[1];
            Secondary friess3 = new Secondary();
            List<string> sideFries = friess3.sideFries;
            string selectedFries = sideFries[0];
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Your combos are " + mainSpaghetti[1] + " and " + sideFries[0]);
            Console.WriteLine("---------------------------------------------------------");
        }
        public void spaghettiCombo4()
        {
            Primary spaghetti4 = new Primary();
            List<string> mainSpaghetti = spaghetti4.mainSpaghetti;
            string selectedBurger = mainSpaghetti[1];
            Secondary friess4 = new Secondary();
            List<string> sideFries = friess4.sideFries;
            string selectedFries = sideFries[1];
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Your combos are " + mainSpaghetti[1] + " and " + sideFries[1]);
            Console.WriteLine("---------------------------------------------------------------");
        }
        public void spaghettiCombo5()
        {
            Primary spaghetti5 = new Primary();
            List<string> mainSpaghetti = spaghetti5.mainSpaghetti;
            string selectedBurger = mainSpaghetti[0];
            Secondary beverages1 = new Secondary();
            List<string> sidebeverage = beverages1.sideBeverage;
            string selectedBeverage = sidebeverage[0];
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Your combos are " + mainSpaghetti[0] + " and " + sidebeverage[0]);
            Console.WriteLine("------------------------------------------");
        }
        public void spaghettiCombo6()
        {
            Primary spaghetti6 = new Primary();
            List<string> mainSpaghetti = spaghetti6.mainBurger;
            string selectedBurger = mainSpaghetti[0];
            Secondary beverages2 = new Secondary();
            List<string> sidebeverage = beverages2.sideBeverage;
            string selectedBeverage = sidebeverage[1];
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Your combos are " + mainSpaghetti[0] + " and " + sidebeverage[1]);
            Console.WriteLine("----------------------------------------------");
        }
        public void spaghettiCombo7()
        {
            Primary spaghetti7 = new Primary();
            List<string> mainSpaghetti = spaghetti7.mainSpaghetti;
            string selectedBurger = mainSpaghetti[1];
            Secondary beverages3 = new Secondary();
            List<string> sidebeverage = beverages3.sideBeverage;
            string selectedBeverage = sidebeverage[0];
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Your combos are " + mainSpaghetti[1] + " and " + sidebeverage[0]);
            Console.WriteLine("-------------------------------------------------");
        }
        public void spaghettiCombo8()
        {
            Primary spaghetti8 = new Primary();
            List<string> mainSpaghetti = spaghetti8.mainSpaghetti;
            string selectedBurger = mainSpaghetti[1];
            Secondary beverages4 = new Secondary();
            List<string> sidebeverage = beverages4.sideBeverage;
            string selectedBeverage = sidebeverage[1];
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Your combos are " + mainSpaghetti[1] + " and " + sidebeverage[1]);
            Console.WriteLine("--------------------------------------------------");
        }
        public void chickenCombo1()
        {
            Primary chicken1 = new Primary();
            List<string> mainChicken = chicken1.mainChicken;
            string selectedBurger = mainChicken[0];
            Secondary friesc1 = new Secondary();
            List<string> sideFries = friesc1.sideFries;
            string selectedFries = sideFries[0];
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Your combos are " + mainChicken[0] + " and " + sideFries[0]);
            Console.WriteLine("--------------------------------------------------------");
        }
        public void chickenCombo2()
        {
            Primary chicken2 = new Primary();
            List<string> mainChicken = chicken2.mainChicken;
            string selectedBurger = mainChicken[0];
            Secondary friesc2 = new Secondary();
            List<string> sideFries = friesc2.sideFries;
            string selectedFries = sideFries[1];
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Your combos are " + mainChicken[0] + " and " + sideFries[1]);
            Console.WriteLine("--------------------------------------------------------------");
        }
        public void chickenCombo3()
        {
            Primary chicken3 = new Primary();
            List<string> mainChicken = chicken3.mainChicken;
            string selectedBurger = mainChicken[1];
            Secondary friesc3 = new Secondary();
            List<string> sideFries = friesc3.sideFries;
            string selectedFries = sideFries[0];
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Your combos are " + mainChicken[1] + " and " + sideFries[0]);
            Console.WriteLine("---------------------------------------------------");
        }
        public void chickenCombo4()
        {
            Primary chicken4 = new Primary();
            List<string> mainChicken = chicken4.mainChicken;
            string selectedBurger = mainChicken[1];
            Secondary friesc4 = new Secondary();
            List<string> sideFries = friesc4.sideFries;
            string selectedFries = sideFries[1];
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Your combos are " + mainChicken[1] + " and " + sideFries[1]);
            Console.WriteLine("---------------------------------------------------------");
        }
        public void chickenCombo5()
        {
            Primary chicken5 = new Primary();
            List<string> mainChicken = chicken5.mainChicken;
            string selectedBurger = mainChicken[0];
            Secondary beveragec1 = new Secondary();
            List<string> sidebeverage = beveragec1.sideBeverage;
            string selectedBeverage = sidebeverage[0];
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Your combos are " + mainChicken[0] + " and " + sidebeverage[0]);
            Console.WriteLine("------------------------------------------------");
        }
        public void chickenCombo6()
        {
            Primary chicken6 = new Primary();
            List<string> mainChicken = chicken6.mainChicken;
            string selectedBurger = mainChicken[0];
            Secondary beveragec2 = new Secondary();
            List<string> sidebeverage = beveragec2.sideBeverage;
            string selectedBeverage = sidebeverage[1];
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Your combos are " + mainChicken[0] + " and " + sidebeverage[1]);
            Console.WriteLine("-------------------------------------------------");
        }
        public void chikenCombo7()
        {
            Primary chicken7 = new Primary();
            List<string> mainChicken = chicken7.mainChicken;
            string selectedBurger = mainChicken[1];
            Secondary beveragec3 = new Secondary();
            List<string> sidebeverage = beveragec3.sideBeverage;
            string selectedBeverage = sidebeverage[0];
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Your combos are " + mainChicken[1] + " and " + sidebeverage[0]);
            Console.WriteLine("-------------------------------------------");
        }
        public void chickenCombo8()
        {
            Primary chicken8 = new Primary();
            List<string> mainChicken = chicken8.mainChicken;
            string selectedBurger = mainChicken[1];
            Secondary beveragec4 = new Secondary();
            List<string> sidebeverage = beveragec4.sideBeverage;
            string selectedBeverage = sidebeverage[1];
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Your combos are " + mainChicken[1] + " and " + sidebeverage[1]);
            Console.WriteLine("--------------------------------------------");
        }
    }
}

