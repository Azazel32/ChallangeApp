﻿namespace ChallangeApp
{
    public class Supervisior : IEmployee
    {
        string IEmployee.Name => throw new NotImplementedException();

        int IEmployee.Age => throw new NotImplementedException();

        string IEmployee.Lastname => throw new NotImplementedException();

        char IEmployee.Sex => throw new NotImplementedException();

        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.AddGrade(100);
                    break;
                case "-6":
                case "6-":
                    this.AddGrade(95);
                    break;
                case "5":
                    this.AddGrade(80);
                    break;
                case "5+":
                case "+5":
                    this.AddGrade(85);
                    break;
                case "5-":
                case "-5":
                    this.AddGrade(75);
                    break;
                case "4-":
                case "-4":
                    this.AddGrade(55);
                    break;
                case "4":
                    this.AddGrade(60);
                    break;
                case "+4":
                case "4+":
                    this.AddGrade(65);
                    break;
                case "3":
                    this.AddGrade(40);
                    break;
                case "+3":
                case "3+":
                    this.AddGrade(45);
                    break;
                case "-3":
                case "3-":
                    this.AddGrade(35);
                    break;
                case "2":
                    this.AddGrade(20);
                    break;
                case "2+":
                case "+2":
                    this.AddGrade(25);
                    break;
                case "2-":
                case "-2":
                    this.AddGrade(15);
                    break;
                case "1+":
                case "+1":
                    this.AddGrade(5);
                    break;
                case "1":
                    this.AddGrade(0);
                    break;
                default:

                    break;
            }
        }

        public void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }

        public Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
