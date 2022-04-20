String name = "";
String birthday = " ";
String ID = "";
String gender = "";
String check = "";
int revise = 1;
int restart = 1;
int again = 1;

while(revise == 1)
{
    again = 1;
    Console.WriteLine("What is your name, bro?");
    name = Console.ReadLine();//只對句子管用
    Console.WriteLine("OK, I see. Your name is " + name);

    while(restart == 1)
    {
        Console.WriteLine("Are you a boy or a girl?");
        Console.WriteLine("If you are a boy, please enter 1.");
        Console.WriteLine("If you are a girl, please enter 2.");
        gender = Console.ReadLine();

        if(gender == "1")
        {
            Console.WriteLine("OK, you are da GG");
            gender = "boy";
            break;
        }
        else if(gender == "2")
        {
            Console.WriteLine("OK, you are a girl, I love girl.");
            gender = "girl";
            break;
        }
        else
        {
            Console.WriteLine("Are you kidding me???");
        }
    }
    Console.WriteLine("When is your birthday?");
    birthday = Console.ReadLine();
    Console.WriteLine("Ok. Your birthday is " + birthday);

    Console.WriteLine("What is your school ID?");
    ID = Console.ReadLine();
    Console.WriteLine("OK, you are so good good.");

    Console.WriteLine("Please check out the data.");
    Console.WriteLine(name);
    Console.WriteLine(gender);
    Console.WriteLine(birthday);
    Console.WriteLine(ID);

    while(again == 1)
    {
        Console.WriteLine("Does the data correct?");
        Console.WriteLine("If it is correct, please enter 1.");
        Console.WriteLine("If you want to revise the data, please enter 2.");
        check = Console.ReadLine();

        if(check == "1")
        {
            Console.WriteLine("Data creation completed.You are so good good.");
            revise = 2;
            again = 2;
        }
        else if(check == "2")
        {
            Console.WriteLine("You are so bad bad.Please start filling out again.");
            again = 2;
        }
        else
        {
            Console.WriteLine("Stupid don't make a fuss.");
        }
    }
}