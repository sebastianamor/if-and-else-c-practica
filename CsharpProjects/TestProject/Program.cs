Random random = new Random();
int discountDay = random.Next(12);
int discountPercentage = 0;

int total = discountDay;

if (total == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (total == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (total <= 5)
{
    Console.WriteLine($"Your subscription expires in {total} days.");
    discountPercentage = 10;
}
else if (total <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}