namespace Lesson_71___НАСЛЕДОВАНИЕ_
{
    class LP
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintFullName()
        {
            System.Console.WriteLine($"Name: {FirstName}, LastName: {LastName}");
        }
    }
}
