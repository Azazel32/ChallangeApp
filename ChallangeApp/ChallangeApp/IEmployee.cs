namespace ChallangeApp
{
    public interface IEmployee
    {
        string Name { get; }
        int Age { get; }
        string LastName { get; }
        
        void AddGrade(char grade);
        void AddGrade(double grade);
        void AddGrade(string grade);
        void AddGrade(float grade);
        Statistics GetStatistics();
    }
}
