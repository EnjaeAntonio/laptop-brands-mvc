using MVCAssessment.Models;

namespace MVCAssessment.Data
{
    public static class Context
    {
        public static HashSet<Laptop> Laptops = new HashSet<Laptop>();
        public static HashSet<Brand> Brands = new HashSet<Brand>();

        private static int _idCounter = 0;

        public static int GetIdCount()
        {
            _idCounter++;
            return _idCounter;
        }
        private static void _seedMethod()
        {
            Brand brand1 = new Brand("Apple");
            Brand brand2 = new Brand("Asus");
            Brand brand3 = new Brand("Lenovo");

            Brands.Add(brand1);
            Brands.Add(brand2);
            Brands.Add(brand3);

            Laptop appleAirM1New = new Laptop("Macbook Air (M1) !Brand New!", brand1, 1199, 500, new DateTime(2022, 10, 22), "New");
            Laptop appleAirM1Refurb = new Laptop("Macbook Air (M1) !Refurbished!", brand1, 699, 50, new DateTime(2022, 10, 22), "Refurbished");
            Laptop appleAirM1Rental = new Laptop("Macbook Air (M1) !Rental!", brand1, 50, 40, new DateTime(2022, 10, 22), "Rental");

            Laptop appleAirM2New = new Laptop("Macbook Air (M2) !New!", brand1, 1899, 750, new DateTime(2022, 6, 15), "New");
            Laptop appleAirM2Refurb = new Laptop("Macbook Air (M2) !Refurbished!", brand1, 1399, 75, new DateTime(2022, 6, 15), "Refurbished");
            Laptop appleAirM2Rental = new Laptop("Macbook Air (M2) !Rental!", brand1, 50, 20, new DateTime(2022, 6, 15), "Rental");

            Laptop appleProNew = new Laptop("Macbook Pro !New!", brand1, 1999, 500, new DateTime(2023, 1, 7), "New");
            Laptop appleProRefurb = new Laptop("Macbook Pro !Refurbished!", brand1, 1499, 125, new DateTime(2023, 1, 7), "Refurbished");
            Laptop appleProRental = new Laptop("Macbook Pro !Rental!", brand1, 100, 10, new DateTime(2023, 1, 7), "Rental");


            Laptop AsusG15New = new Laptop("Rog Strix G15 Asus !New!", brand2, 1699, 250, new DateTime(2020, 4, 17), "New");
            Laptop AsusG15Refurb = new Laptop("Rog Strix G15 Asus !Refurbished!", brand2, 1199, 125, new DateTime(2020, 4, 17), "Refurb");
            Laptop AsusG15Rental = new Laptop("Rog Strix G15 Asus !Rental!", brand2, 100, 20, new DateTime(2020, 4, 17), "Rental");

            Laptop AsusTUFNew = new Laptop("TUF Gaming A17 !New!", brand2, 1499, 250, new DateTime(2022, 7, 11), "New");
            Laptop AsusTUFRefurb = new Laptop("TUF Gaming A17 !Refurbished!", brand2, 999, 125, new DateTime(2022, 7, 11), "Refurb");
            Laptop AsusTUFRental = new Laptop("TUF Gaming A17 !Rental!", brand2, 100, 20, new DateTime(2022, 7, 11), "Rental");

            Laptop AsusZenbookNew = new Laptop("TUF Gaming A17 !New!", brand2, 1699, 250, new DateTime(2022, 2, 12), "New");
            Laptop AsusZenbookRefurb = new Laptop("TUF Gaming A17 !Refurbished!", brand2, 1199, 125, new DateTime(2022, 2, 12), "Refurb");
            Laptop AsusZenbookRental = new Laptop("TUF Gaming A17 !Rental!", brand2, 100, 20, new DateTime(2022, 2, 12), "Rental");

            Laptop AsusZephG14New = new Laptop("ROG Zephyrus G14 !New!", brand2, 1999, 100, new DateTime(2022, 5, 14), "New");
            Laptop AsusZephG14Refurb = new Laptop("ROG Zephyrus G14 !Refurbished!", brand2, 1499, 40, new DateTime(2022, 5, 14), "Refurbished");
            Laptop AsusZephG14Rental = new Laptop("ROG Zephyrus G14 !Rental!", brand2, 100, 10, new DateTime(2022, 5, 14), "Rental");

            Laptop AsusZephG15New = new Laptop("ROG Zephyrus G15 !New!", brand2, 2999, 50, new DateTime(2022, 9, 18), "New");
            Laptop AsusZephG15Refurb = new Laptop("ROG Zephyrus G15 !Refurbished!", brand2, 2299, 20, new DateTime(2022, 9, 18), "Refurbished");
            Laptop AsusZephG15Rental = new Laptop("ROG Zephyrus G15 !Rental!", brand2, 200, 4, new DateTime(2022, 9, 18), "Rental");

            Laptop LenovoLegin5New = new Laptop("Legion 5 !New!", brand3, 1599, 20, new DateTime(2021, 4, 5), "New");
            Laptop LenovoLegin5Refurb = new Laptop("Legion 5 !Refurbished!", brand3, 1099, 5, new DateTime(2021, 4, 5), "Refurbished");
            Laptop LenovoLegin5Rental = new Laptop("Legion 5 !Rental!", brand3, 50, 3, new DateTime(2021, 4, 5), "Rental");

            Laptop LenovoLegin5ProNew = new Laptop("Legion 5 Pro !New!", brand3, 1699, 30, new DateTime(2021, 4, 5), "New");
            Laptop LenovoLegin5ProRefurb = new Laptop("Legion 5 Pro !Refurbished!", brand3, 1199, 5, new DateTime(2021, 4, 5), "Refurbished");
            Laptop LenovoLegin5ProRental = new Laptop("Legion 5 Pro !Rental!", brand3, 50, 3, new DateTime(2021, 4, 5), "Rental");

            Laptop Lenovo5NewestModelNew = new Laptop("Legion 5 15ARH7h !New!", brand3, 1799, 100, new DateTime(2022, 8, 15), "New");
            Laptop Lenovo5NewestModelRefurb = new Laptop("Legion 5 15ARH7h !Refurbished!", brand3, 1499, 30, new DateTime(2022, 8, 15), "Refurbished");
            Laptop Lenovo5NewestModelRental = new Laptop("Legion 5 15ARH7h !Rental!", brand3, 100, 2, new DateTime(2022, 8, 15), "Rental");

            // Adding the new laptops to the HashSet
            Laptops.Add(appleAirM1New);
            Laptops.Add(appleAirM1Refurb);
            Laptops.Add(appleAirM1Rental);
            Laptops.Add(appleAirM2New);
            Laptops.Add(appleAirM2Refurb);
            Laptops.Add(appleAirM2Rental);
            Laptops.Add(appleProNew);
            Laptops.Add(appleProRefurb);
            Laptops.Add(appleProRental);

            Laptops.Add(AsusG15New);
            Laptops.Add(AsusG15Refurb);
            Laptops.Add(AsusG15Rental);
            Laptops.Add(AsusTUFNew);
            Laptops.Add(AsusTUFRefurb);
            Laptops.Add(AsusTUFRental);
            Laptops.Add(AsusZenbookNew);
            Laptops.Add(AsusZenbookRefurb);
            Laptops.Add(AsusZenbookRental);
            Laptops.Add(AsusZephG14New);
            Laptops.Add(AsusZephG14Refurb);
            Laptops.Add(AsusZephG14Rental);
            Laptops.Add(AsusZephG15New);
            Laptops.Add(AsusZephG15Refurb);
            Laptops.Add(AsusZephG15Rental);

            Laptops.Add(LenovoLegin5New);
            Laptops.Add(LenovoLegin5Refurb);
            Laptops.Add(LenovoLegin5Rental);
            Laptops.Add(LenovoLegin5ProNew);
            Laptops.Add(LenovoLegin5ProRefurb);
            Laptops.Add(LenovoLegin5ProRental);
            Laptops.Add(Lenovo5NewestModelNew);
            Laptops.Add(Lenovo5NewestModelRefurb);
            Laptops.Add(Lenovo5NewestModelRental);


        }

        static Context()
        {
            _seedMethod();
        }
    }


}
