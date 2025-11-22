// EXCEEDING REQUIREMENTS:
// 1. Added a simple leveling system - users level up every 1000 points
// 2. Added fun titles that change as you level up

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.Display();
    }
}