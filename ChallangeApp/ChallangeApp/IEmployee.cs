namespace ChallangeApp
{
    internal interface IEmployee
    {
        string Name { get; }
        int Age { get; }
        string Lastname { get; }
        char Sex { get; }
        void AddGrade(char grade);
        void AddGrade(double grade);
        void AddGrade(string grade);
        void AddGrade(float grade);
        Statistics GetStatistics();
    }
}
