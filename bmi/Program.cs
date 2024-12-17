//using System.Runtime.Intrinsics.X86;
// calculate BMI 
Console.WriteLine("Eneter your weight : ");
string kg = Console.ReadLine();

Console.WriteLine("Enter your height :");
string cm = Console.ReadLine();

double weight = Convert.ToInt32(kg);
double height = Convert.ToInt32(cm);

double bmi = (weight / Math.Pow(height/100, 2));

Console.WriteLine("your bmi is : " + bmi);

Console.WriteLine("--------------------------------------");

// CHECK BMI STATE 

string BmiState;

if (bmi < 18.5) 
{
    BmiState = "underweight";
}
else if (bmi >= 18.5 && bmi <= 24.9)
{
    BmiState = "healthy";
}
else if (bmi >= 25.0 && bmi <= 29.9)
{
    BmiState = "overweight";
}
else if (bmi > 30)
{
    BmiState = "obese";
}
Console.WriteLine(BmiState);


//Console.WriteLine("--------------------------------------");

// CHECK BMI STATE BY AGE 

Console.WriteLine("Enter BMI : ");
string bodymass = Console.ReadLine();

Console.WriteLine("Enter AGE : ");
string agenumber =  Console.ReadLine();

double bmii = Convert.ToInt32(bodymass);
double age = Convert.ToInt32(agenumber);

if ((age >= 65) && (bmii >= 24 && bmii <= 29))
{
    BmiState = "healthy";
else if ((age >= 55) && (bmii >= 23 && bmii <= 28))
    {
        BmiState = "healthy";
    }
    else if ((age >= 45) && (bmii >= 22 && bmii <= 27))
    {
        BmiState = "healthy";
    }
    else if ((age >= 35) && (bmii >= 21 && bmii <= 26))
    {
        BmiState = "healthy";
    }
    else if ((age >= 25) && (bmii >= 20 && bmii <= 25))
    {
        BmiState = "healthy";
    }
    else if ((age >= 19) && (bmii >= 19 && bmii <= 24))
    {
        BmiState = "healthy";
    }
    else
    {
        BmiState = "unhealthy";
    }
    Console.WriteLine(bmiState);
}
