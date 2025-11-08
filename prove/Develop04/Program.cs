// Exceeds requirements by adding an interactive spinner animation, allowing user input in the Reflection Activity, and organizing each class into separate files for clean structure.
// Also I had to go and relearn how to use cases for the code. I did it for another project but it was cool to be able to use it here as well. Same with using a namespace in this file.

using System;

namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.DisplayMenu();
        }
    }
}
