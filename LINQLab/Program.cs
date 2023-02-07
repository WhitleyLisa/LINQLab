// LINQ Lab


int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };

// number 1: Find the Minimum value 

int minimumValue = nums.Min();
Console.WriteLine($"The minimum value is: {minimumValue}");

// number 2: Find the Maximum value

int maximumValue = nums.Max();
Console.WriteLine($"The Maximum value is: {maximumValue}");

// number 3: Find the Maximum value less than 10000

int maximumValueLessThan10000 = nums.Where(n => n <= 10000).Max();
Console.WriteLine($"The Maximum value less than 10,000 is: {maximumValue}");

// number 4: Find all the values between 10 and 100

int valuesBetween10And100 = nums.Where(nums => nums >= 10 && nums <= 100).Max();
Console.WriteLine($"The values between 10 and 100 are: {maximumValue}");


// number 5: Find all the Values between 100000 and 999999 inclusive 

// attempt here:

// number 6:Count all the even numbers 

int evenNumbers = nums.Count().Where(x => x %2 == evenNumber);


