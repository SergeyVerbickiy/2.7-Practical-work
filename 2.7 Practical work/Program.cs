using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2._7_Practical_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Иванов Борис Иванович";

            string email = "Ivanovich@boris.ru";

            byte age = 46;

            double programmingPoints = 56.7;
            double mathScores = 58.5;
            double physicsScores = 69.2;

            string newDataUser = "ФИО: {0,48} \n\nВозраст: {1,25} \n\nE-mail {2,43} \n\nБалы по программированию: {3,10} \n\nБалы по математике: {4,16} \n\nБалы по физике: {5,20} \n\n";
            Console.WriteLine(newDataUser,
                fullName,
                age,
                email,
                programmingPoints,
                mathScores,
                physicsScores);

            Console.ReadKey();

            double totalPoint = programmingPoints + mathScores + physicsScores;
            double averageScore = totalPoint / 3;

            string averageScoreFormated = averageScore.ToString("#.##");

            string newScoringPoints = "Общее колличество балов: {0,12} \n\n Средний бал: {1,24}";
            Console.WriteLine(newScoringPoints,
                totalPoint,
                averageScoreFormated);

            Console.ReadKey();


        }
    }
}
