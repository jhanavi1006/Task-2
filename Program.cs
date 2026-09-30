Console.WriteLine("Please enter your age");
int age = Convert.ToInt32(Console.ReadLine());

if (age < 0 || age > 109)
{
    Console.WriteLine("Invalid age");

}
else if (age < 13)
{
    Console.WriteLine("You are a minor");
}
else if (age >= 13 && age < 19)
{
    Console.WriteLine("You are a teenager");
}
else
{
    Console.WriteLine("You are a senior citizen");
}