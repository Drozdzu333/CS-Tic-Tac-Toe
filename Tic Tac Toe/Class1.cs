using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public class Board
    {

        char A1 = 'O';
        char A2 = 'O';
        char A3 = 'O';
        char B1 = 'O';
        char B2 = 'O';
        char B3 = 'O';
        char C1 = 'O';
        char C2 = 'O';
        char C3 = 'O';
        public Board(string[] marks)
        {
            //string[] Marks = marks;

            //Console.WriteLine("    A   B    C");
            //Console.WriteLine($"1   {A1} | {B1} | {C1}");
            // Console.WriteLine("________________");
            //Console.WriteLine($"1   {A2} | {B2} | {C2}");
            // Console.WriteLine("________________");
            //Console.WriteLine($"1   {A3} | {B3} | {C3}");

            Console.WriteLine("    A   B    C");
            Console.WriteLine($"1   {marks[0]} | {marks[1]} | {marks[2]}");
            Console.WriteLine("________________");
            Console.WriteLine($"1   {marks[0]} | {marks[0]} | {marks[0]}");
            Console.WriteLine("________________");
            Console.WriteLine($"1   {marks[0]} | {marks[0]} | {marks[0]}");
        }
    }
}
