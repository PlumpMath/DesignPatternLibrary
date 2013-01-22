using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Composite.Interface;
namespace Composite
{
    public class Program
    {
        static void Main()
        {
            var qualityTeam = new QualityTeamEmailGroup();
            qualityTeam.qualityTeamEmailGroup = new List<IEmail>();
            var test1 = new PersonalEmail("Test1@test.com");
            var test2 = new PersonalEmail("Test2@test.com");
            var test3 = new PersonalEmail("Test3@test.com");
            qualityTeam.qualityTeamEmailGroup.Add(test1);
            qualityTeam.qualityTeamEmailGroup.Add(test2);
            qualityTeam.qualityTeamEmailGroup.Add(test3);
            var ceo = new PersonalEmail("ceo@testc.com");

            var emailsTobeSent=new QualityTeamEmailGroup();
            emailsTobeSent.qualityTeamEmailGroup.Add(qualityTeam);
            emailsTobeSent.qualityTeamEmailGroup.Add(ceo);

            emailsTobeSent.Send();
            

            Console.WriteLine("--------------------------------------");
        }

    }
}
