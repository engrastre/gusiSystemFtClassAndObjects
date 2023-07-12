using gusiSystemClassandObjects;

namespace gusiSystemFtClassAndObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            int answer, main, selectedBurger, selectedSpaghetti, selectedChicken, side, selectedFries, selectedBeverage;
            Menu apear = new Menu();
            apear.menu();
            answer = Convert.ToInt32(Console.ReadLine());
            bool proceed = true;
            while (proceed)
            {
                if (answer == 1)
                {
                    Menu list = new Menu();
                    list.offeredMains();
                    main = Convert.ToInt32(Console.ReadLine());
                    if (main == 1) //burger
                    {
                        Primary burger = new Primary();
                        burger.burgerList();
                        selectedBurger = Convert.ToInt32(Console.ReadLine());
                        if (selectedBurger == 1)
                        {
                            Menu secondary = new Menu();
                            secondary.offeredPairs();
                            side = Convert.ToInt32(Console.ReadLine());
                            if (side == 1)
                            {
                                Secondary fries = new Secondary();
                                fries.frieslist();
                                selectedFries = Convert.ToInt32(Console.ReadLine());
                                if (selectedFries == 1)
                                {
                                    Combo cb1 = new Combo();
                                    cb1.burgerCombo1();
                                    Payment payment = new Payment();
                                    payment.pay();
                                    Menu menu = new Menu();
                                    menu.menuu();
                                }
                                else if (selectedFries == 2)
                                {
                                    Combo cb2 = new Combo();
                                    cb2.burgerCombo2();
                                    Payment payment = new Payment();
                                    payment.pay();
                                    Menu menu = new Menu();
                                    menu.menuu();
                                }
                                else
                                {
                                    Menu invalid = new Menu();
                                    invalid.invalidInput();
                                    selectedFries = Convert.ToInt32(Console.ReadLine());
                                }

                            }
                            else if (side == 2)
                            {
                                Secondary beverage = new Secondary();
                                beverage.beveragelist();
                                selectedBeverage = Convert.ToInt32(Console.ReadLine());
                                if (selectedBeverage == 1)
                                {
                                    Combo cb5 = new Combo();
                                    cb5.burgerCombo5();
                                    Payment payment = new Payment();
                                    payment.pay();
                                    Menu menu = new Menu();
                                    menu.menuu();
                                }
                                else if (selectedBeverage == 2)
                                {
                                    Combo cb6 = new Combo();
                                    cb6.burgerCombo6();
                                    Payment payment = new Payment();
                                    payment.pay();
                                    Menu menu = new Menu();
                                    menu.menuu();
                                }
                                else
                                {
                                    Menu invalid = new Menu();
                                    invalid.invalidInput();
                                    selectedBeverage = Convert.ToInt32(Console.ReadLine());
                                }
                            }
                            else
                            {
                                Menu invalid = new Menu();
                                invalid.invalidInput();
                                side = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        else if (selectedBurger == 2)
                        {
                            Menu secondary = new Menu();
                            secondary.offeredPairs();
                            side = Convert.ToInt32(Console.ReadLine());
                            if (side == 1)
                            {
                                Secondary fries = new Secondary();
                                fries.frieslist();
                                selectedFries = Convert.ToInt32(Console.ReadLine());
                                if (selectedFries == 1)
                                {
                                    Combo cb3 = new Combo();
                                    cb3.burgerCombo3();
                                    Payment payment = new Payment();
                                    payment.pay();
                                    Menu menu = new Menu();
                                    menu.menuu();
                                }
                                else if (selectedFries == 2)
                                {
                                    Combo cb4 = new Combo();
                                    cb4.burgerCombo4();
                                    Payment payment = new Payment();
                                    payment.pay();
                                    Menu menu = new Menu();
                                    menu.menuu();
                                }
                                else
                                {
                                    Menu invalid = new Menu();
                                    invalid.invalidInput();
                                    selectedFries = Convert.ToInt32(Console.ReadLine());
                                }

                            }
                            else if (side == 2)
                            {
                                Secondary beverage = new Secondary();
                                beverage.beveragelist();
                                selectedBeverage = Convert.ToInt32(Console.ReadLine());
                                if (selectedBeverage == 1)
                                {
                                    Combo cb7 = new Combo();
                                    cb7.burgerCombo7();
                                    Payment payment = new Payment();
                                    payment.pay();
                                    Menu menu = new Menu();
                                    menu.menuu();
                                }
                                else if (selectedBeverage == 2)
                                {
                                    Combo cb8 = new Combo();
                                    cb8.burgerCombo8();
                                    Payment payment = new Payment();
                                    payment.pay();
                                    Menu menu = new Menu();
                                    menu.menuu();
                                }
                                else
                                {
                                    Menu invalid = new Menu();
                                    invalid.invalidInput();
                                    selectedBeverage = Convert.ToInt32(Console.ReadLine());
                                }
                            }
                            else
                            {
                                Menu invalid = new Menu();
                                invalid.invalidInput();
                                side = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                       
                    }
                    else if (main == 2) //spaghetti
                    {
                        Primary spaghetti = new Primary();
                        spaghetti.spaghettiList();
                        selectedSpaghetti = Convert.ToInt32(Console.ReadLine());
                        if (selectedSpaghetti == 1) // spaghetti type
                        {
                            Menu secondary = new Menu();
                            secondary.offeredPairs();
                            side = Convert.ToInt32(Console.ReadLine());
                            if (side == 1)
                            {
                                Secondary fries = new Secondary();
                                fries.frieslist();
                                selectedFries = Convert.ToInt32(Console.ReadLine());
                                if (selectedFries == 1)
                                {
                                    Combo cs1 = new Combo();
                                    cs1.spaghettiCombo1();
                                    Payment payment = new Payment();
                                    payment.pay();
                                    Menu menu = new Menu();
                                    menu.menuu();
                                }
                                else if (selectedFries == 2)
                                {
                                    Combo cs2 = new Combo();
                                    cs2.spaghettiCombo2();
                                    Payment payment = new Payment();
                                    payment.pay();
                                    Menu menu = new Menu();
                                    menu.menuu();
                                }
                                else
                                {
                                    Menu invalid = new Menu();
                                    invalid.invalidInput();
                                    selectedFries = Convert.ToInt32(Console.ReadLine());
                                }

                            }
                            else if (side == 2)
                            {
                                Secondary beverage = new Secondary();
                                beverage.beveragelist();
                                selectedBeverage = Convert.ToInt32(Console.ReadLine());
                                if (selectedBeverage == 1)
                                {
                                    Combo cs5 = new Combo();
                                    cs5.spaghettiCombo5();
                                    Payment payment = new Payment();
                                    payment.pay();
                                    Menu menu = new Menu();
                                    menu.menuu();
                                }
                                else if (selectedBeverage == 2)
                                {
                                    Combo cs6 = new Combo();
                                    cs6.spaghettiCombo6();
                                    Payment payment = new Payment();
                                    payment.pay();
                                    Menu menu = new Menu();
                                    menu.menuu();
                                }
                                else
                                {
                                    Menu invalid = new Menu();
                                    invalid.invalidInput();
                                    selectedBeverage = Convert.ToInt32(Console.ReadLine());
                                }
                            }
                            else
                            {
                                Menu invalid = new Menu();
                                invalid.invalidInput();
                                side = Convert.ToInt32(Console.ReadLine());
                            }

                        }
                        else if (selectedSpaghetti == 2)
                        {
                            Menu secondary = new Menu();
                            secondary.offeredPairs();
                            side = Convert.ToInt32(Console.ReadLine());
                            if (side == 1)
                            {
                                Secondary fries = new Secondary();
                                fries.frieslist();
                                selectedFries = Convert.ToInt32(Console.ReadLine());
                                if (selectedFries == 1)
                                {
                                    Combo cs3 = new Combo();
                                    cs3.spaghettiCombo3();
                                    Payment payment = new Payment();
                                    payment.pay();
                                    Menu menu = new Menu();
                                    menu.menuu();
                                }
                                else if (selectedFries == 2)
                                {
                                    Combo cs4 = new Combo();
                                    cs4.spaghettiCombo4();
                                    Payment payment = new Payment();
                                    payment.pay();
                                    Menu menu = new Menu();
                                    menu.menuu();
                                }
                                else
                                {
                                    Menu invalid = new Menu();
                                    invalid.invalidInput();
                                    selectedFries = Convert.ToInt32(Console.ReadLine());
                                }

                            }
                            else if (side == 2)
                            {
                                Secondary beverage = new Secondary();
                                beverage.beveragelist();
                                selectedBeverage = Convert.ToInt32(Console.ReadLine());
                                if (selectedBeverage == 1)
                                {
                                    Combo cs7 = new Combo();
                                    cs7.spaghettiCombo7();
                                    Payment payment = new Payment();
                                    payment.pay();
                                    Menu menu = new Menu();
                                    menu.menuu();
                                }
                                else if (selectedBeverage == 2)
                                {
                                    Combo cs8 = new Combo();
                                    cs8.spaghettiCombo8();
                                    Payment payment = new Payment();
                                    payment.pay();
                                    Menu menu = new Menu();
                                    menu.menuu();
                                }
                                else
                                {
                                    Menu invalid = new Menu();
                                    invalid.invalidInput();
                                    selectedBeverage = Convert.ToInt32(Console.ReadLine());
                                }
                            }
                            else
                            {
                                Menu invalid = new Menu();
                                invalid.invalidInput();
                                side = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        else
                        {
                            Menu invalid = new Menu();
                            invalid.invalidInput();
                            side = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    else if (main == 3) //chicken
                    {
                        Primary chicken = new Primary();
                        chicken.chickenList();
                        selectedChicken = Convert.ToInt32(Console.ReadLine());
                        if (selectedChicken == 1) 
                        {
                            Menu secondary = new Menu();
                            secondary.offeredPairs();
                            side = Convert.ToInt32(Console.ReadLine());
                            if (side == 1)
                            {
                                Secondary fries = new Secondary();
                                fries.frieslist();
                                selectedFries = Convert.ToInt32(Console.ReadLine());
                                if (selectedFries == 1)
                                {
                                    Combo cc1 = new Combo();
                                    cc1.chickenCombo1();
                                    Payment payment = new Payment();
                                    payment.pay();
                                    Menu menu = new Menu();
                                    menu.menuu();
                                }
                                else if (selectedFries == 2)
                                {
                                    Combo cc2 = new Combo();
                                    cc2.chickenCombo2();
                                    Payment payment = new Payment();
                                    payment.pay();
                                    Menu menu = new Menu();
                                    menu.menuu();
                                }
                                else
                                {
                                    Menu invalid = new Menu();
                                    invalid.invalidInput();
                                    selectedFries = Convert.ToInt32(Console.ReadLine());
                                }

                            }
                            else if (side == 2)
                            {
                                Secondary beverage = new Secondary();
                                beverage.beveragelist();
                                selectedBeverage = Convert.ToInt32(Console.ReadLine());
                                if (selectedBeverage == 1)
                                {
                                    Combo cc5 = new Combo();
                                    cc5.chickenCombo5();
                                    Payment payment = new Payment();
                                    payment.pay();
                                    Menu menu = new Menu();
                                    menu.menuu();
                                }
                                else if (selectedBeverage == 2)
                                {
                                    Combo cc6 = new Combo();
                                    cc6.chickenCombo6();
                                    Payment payment = new Payment();
                                    payment.pay();
                                    Menu menu = new Menu();
                                    menu.menuu();
                                }
                                else
                                {
                                    Menu invalid = new Menu();
                                    invalid.invalidInput();
                                    selectedBeverage = Convert.ToInt32(Console.ReadLine());
                                }
                            }
                            else
                            {
                                Menu invalid = new Menu();
                                invalid.invalidInput();
                                side = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        else if (selectedChicken == 2)
                        {
                            Menu secondary = new Menu();
                            secondary.offeredPairs();
                            side = Convert.ToInt32(Console.ReadLine());
                            if (side == 1)
                            {
                                Secondary fries = new Secondary();
                                fries.frieslist();
                                selectedFries = Convert.ToInt32(Console.ReadLine());
                                if (selectedFries == 1)
                                {
                                    Combo cc3 = new Combo();
                                    cc3.chickenCombo3();
                                    Payment payment = new Payment();
                                    payment.pay();
                                    Menu menu = new Menu();
                                    menu.menuu();
                                }
                                else if (selectedFries == 2)
                                {
                                    Combo cc4 = new Combo();
                                    cc4.chickenCombo4();
                                    Payment payment = new Payment();
                                    payment.pay();
                                    Menu menu = new Menu();
                                    menu.menuu();
                                }
                                else
                                {
                                    Menu invalid = new Menu();
                                    invalid.invalidInput();
                                    selectedFries = Convert.ToInt32(Console.ReadLine());
                                }

                            }
                            else if (side == 2)
                            {
                                Secondary beverage = new Secondary();
                                beverage.beveragelist();
                                selectedBeverage = Convert.ToInt32(Console.ReadLine());
                                if (selectedBeverage == 1)
                                {
                                    Combo cc7 = new Combo();
                                    cc7.chikenCombo7();
                                    Payment payment = new Payment();
                                    payment.pay();
                                    Menu menu = new Menu();
                                    menu.menuu();
                                }
                                else if (selectedBeverage == 2)
                                {
                                    Combo cc8 = new Combo();
                                    cc8.chickenCombo8();
                                    Payment payment = new Payment();
                                    payment.pay();
                                    Menu menu = new Menu();
                                    menu.menuu();
                                }
                                else
                                {
                                    Menu invalid = new Menu();
                                    invalid.invalidInput();
                                    selectedBeverage = Convert.ToInt32(Console.ReadLine());
                                }
                            }
                            else
                            {
                                Menu invalid = new Menu();
                                invalid.invalidInput();
                                side = Convert.ToInt32(Console.ReadLine());
                            }
                        }

                        else
                        {
                            Menu invalid = new Menu();
                            invalid.invalidInput();
                            selectedChicken = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    else
                    {
                        Menu invalid = new Menu();
                        invalid.invalidInput();
                        main = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
        }
    }
}