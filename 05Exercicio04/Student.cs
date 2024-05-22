namespace Exercicio04
{
    internal class Student
    {
        public string Name;
        public double GradeA;
        public double GradeB;
        public double GradeC;

        public double CalculateFinalGrade()
        {
            return GradeA + GradeB + GradeC;
        }
                
    }
}
