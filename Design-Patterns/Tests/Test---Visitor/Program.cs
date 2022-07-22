using Design_Pattern___Visitor;

// **********************************  Tax System 1 ********************************** //

// Create the tax system
MidWeekTax taxSystem = new MidWeekTax();

// Create some items
House house = new House(1800000); // 1,800,000
Car car = new Car(155000);        // 155,000
Drink drink = new Drink(12);

// Get Prices With Taxes
var housePlusTax = house.Accept(taxSystem);
var carPlusTax = car.Accept(taxSystem);
var drinkPlusTax = drink.Accept(taxSystem);

// Print Results
Console.WriteLine($"house: {housePlusTax}, car: {carPlusTax}, drink: {drinkPlusTax}");

// **********************************  Tax System 2 ********************************** //

// Create another tax system
WeekendTax taxSystem2 = new WeekendTax();

// Get Prices With Taxes
housePlusTax = house.Accept(taxSystem2);
carPlusTax = car.Accept(taxSystem2);
drinkPlusTax = drink.Accept(taxSystem2);

// Print Results
Console.WriteLine($"house: {housePlusTax}, car: {carPlusTax}, drink: {drinkPlusTax}");


// Force Program To Stay Alive
Console.ReadLine();



