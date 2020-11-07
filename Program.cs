using System;
using System.Collections.Generic;

// 2006tavasz 1. Feladat

// 400 servants
// 400 prison cells && all of them are closed
// 1. Servent opens everything
// 2. Servent :2 cell closed
// 3. Servent :3 cell that is opened to be closed and vice versa
// 4. Servent :4 cell that is opened to be closed and vice versa
// Rest of the servents to be repeated like this^^
// 400. Servent :400 cell to be opened

// Simulate it and print the index of the open celldoors

// Right answer is  // 1, 4, 9, 16, 25 ,36, 49, 64, 81, 100

namespace _2006tavaszF01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating the 400 closed celldoors
            List<bool> cellDoors = new List<bool>();
            for (int l = 0; l < 400; l++)
                cellDoors.Add(false);

            // 1. Servent | Opening every single door

            for (int j = 0; j < 400; j++)
            {
                cellDoors[j] = true;
            }

            // 2. Servent | :2 Door closed

            for (int k = 0; k < cellDoors.Count; k++)
            {
                if ((k + 1) % 2 == 0)
                    cellDoors[k] = false;
            }

            // Rest of the servents

            int serventCounter = 3;
            while(serventCounter != 401)
            {
                for (int cellDoor = 0; cellDoor < cellDoors.Count; cellDoor++)
                {
                    if ((cellDoor + 1) % serventCounter == 0)
                    {
                        cellDoors[cellDoor] = toggleDoorState(cellDoors[cellDoor]);
                        Console.WriteLine("I tuned celldoor " + cellDoor + " into " + cellDoors[cellDoor]);
                    }
                        
                }
                serventCounter++;
            }

            // 400. Servent | 400. cell to be opened

            cellDoors[399] = true;

            // Printing the indexes of the open cell doors

            for(int h = 0; h < cellDoors.Count; h++)
            {
                if (cellDoors[h] == true)
                    Console.WriteLine("Celldoor at: " + (h + 1) + " is open!");
            }
        }
        static bool toggleDoorState(bool input)
        {
            bool returnBool = true;
            if (input == false)
                returnBool = true;

            if (input == true)
                returnBool = false;

            return returnBool;
        }
    }
}


 