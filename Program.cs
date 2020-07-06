using System;
using System.ComponentModel;
using System.Dynamic;
using Test_via_interface;

namespace Tests
{

    
    class Program
    {
        

        static void Main(string[] args)
        {
           
            
            Console.WriteLine("Plese, add number of ticks: ");

            int ticksCountPlus = Convert.ToInt32(Console.ReadLine());
            House ticksAdd = new House(0);
            ticksAdd.AddTicks(ticksCountPlus);

            Console.WriteLine($"{ticksCountPlus} ticks was added");
            Console.WriteLine($"ticks total number: {ticksAdd.CurrentTicksSum}");

            Console.WriteLine("Plese, write number of ticks for exclude: ");

            int ticksCountMines = Convert.ToInt32(Console.ReadLine());
            House ticksExclude = new House(ticksCountPlus);
            ticksExclude.ExcludeTicks(ticksCountMines);

            Console.WriteLine($"{ticksCountMines} ticks was excluded");
            Console.WriteLine($"ticks total number: {ticksExclude.CurrentTicksSum}");



            /*House mosquitoes_count_plus = new House(0);
            int mosquitoes_add = Convert.ToInt32(Console.ReadLine());*/

           /* int add_command = Convert.ToInt32(Console.ReadLine());
            *//*if (add_command == Convert.ToInt32(IncomingCommand(Commands.Add, Animals_Enum.ticks)))*//*
            if (add_command == Convert.ToInt32(IncomingCommand(Commands.Add, Animals_Enum.ticks)))
                // TODO: solve this problem in the future
            {
                Console.WriteLine($"{add_command}");
            }


            int ticksCountPlus = add_command;
            
            House ticksAdd = new House(0);
            ticksAdd.AddTicks(ticksCountPlus);

            Console.WriteLine($"{ticksCountPlus} ticks was added");
            Console.WriteLine($"ticks total number: {ticksAdd.CurrentTicksSum}");

            Console.WriteLine("Plese, write number of ticks for exclude: ");

            int ticksCountMines = Convert.ToInt32(Console.ReadLine());
            House ticksExclude = new House(ticksCountPlus);
            ticksExclude.ExcludeTicks(ticksCountMines);

            Console.WriteLine($"{ticksCountMines} ticks was excluded");
            Console.WriteLine($"ticks total number: {ticksExclude.CurrentTicksSum}");*/


        }

        /*static void IncomingCommand(Commands command, Animals_Enum animal_type)
        {

            

            if (command == Commands.Add && animal_type == Animals_Enum.ticks)
            {

                
                *//*House ticksAdd = new House(0);
                ticksAdd.AddTicks(ticksCountPlus);*//*

            }
            else if (command == Commands.Kill && animal_type == Animals_Enum.ticks)
            {

            }
            else if (command == Commands.Add && animal_type == Animals_Enum.mosquitoes)
            {

            }
            else if (command == Commands.Kill && animal_type == Animals_Enum.mosquitoes)
            {

            }
        }*/
    }
        /*public class Comands
        {
        string add = "Add";
        string kill = "Kill";
        int ticks_count = Convert.ToInt32(Console.ReadLine());
        string ticks = "ticks";
        string mosquitoes = "mosquitoes";
        }*/
    interface IAlive
    {
        int CurrentTicksSum { get; }
        void AddTicks(int sum);
        void ExcludeTicks(int sum);
    }
    interface Iticks
    {
        int ticksAdd { get; }
    }

    class House : IAlive, Iticks
    {
        int ticksSum;
        public House(int sum)
        {
            ticksSum = sum;
        }
        public int CurrentTicksSum { get { return ticksSum; } }

        public int ticksAdd { get; }
        
        public void AddTicks(int sum)
        {
            ticksSum += sum;
        }

        public void ExcludeTicks(int sum)
        {
            if (ticksSum >= sum) 
            {
                ticksSum -= sum;
                
            }
            else
            {
                Console.WriteLine("You can't exclude");
            }
        }
    }
}

            /*Console.WriteLine("Plese, add number of ticks: ");

            int ticksCountPlus = Convert.ToInt32(Console.ReadLine());
            House ticksAdd = new House(0);
            ticksAdd.AddTicks(ticksCountPlus);

            Console.WriteLine($"{ticksCountPlus} ticks was added");
            Console.WriteLine($"ticks total number: {ticksAdd.CurrentTicksSum}");

            Console.WriteLine("Plese, write number of ticks for exclude: ");

            int ticksCountMines = Convert.ToInt32(Console.ReadLine());
            House ticksExclude = new House(ticksCountPlus);
            ticksExclude.ExcludeTicks(ticksCountMines);

            Console.WriteLine($"{ticksCountMines} ticks was excluded");
            Console.WriteLine($"ticks total number: {ticksExclude.CurrentTicksSum}");*/
