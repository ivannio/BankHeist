﻿using System;

namespace BankHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.ReadLine();
            Console.WriteLine("Please enter a name for your first team member.");
            var teamMember = new TeamMember(Console.ReadLine());
            Console.WriteLine("Please enter your team members skill level: (Any number greater than zero)");
            teamMember.SkillLevel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your team members courage factor: (a decimal value between 0.0 and 2.0)");
            teamMember.CourageFactor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Your team member, {teamMember.Name}, has a skill level of {teamMember.SkillLevel} and a courage factor of {teamMember.CourageFactor}");
            Console.ReadLine();
        }
    }
}
