Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here

int total = daysUntilExpiration;

if (total <= 12)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if (total <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days .
Renew now and save 10%!");
}
else if (total <= 1)
{
    Console.WriteLine($" Your subscription expires within a day!
Renew now and save 20%!");
}
else if ( total === 0 )
{
    Console.WriteLine("Your subscription has expired.   ");
    
}