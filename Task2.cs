using System;
using System.Collections.Generic;
using System.Text;
/*
"4+(3+5)*(7-1)"
"(123/4*(4+2))"
"(3+4) * 5) - (4"

*/
namespace _2006tavaszF01
{
    class Task2
    {
        public static string Task02(string input)
        {
            string[] answers = { "HIBA: Eltérő számú nyitó és zárójelek.", "Egyező számú zárójelek.", "HIBA: Zárójelek rossz sorrendben.", "Megfelelő zárójel sorrend."};
            bool leftSide = false;
            bool rightSide = false;
            int leftCounter = 0;
            int rightCounter = 0;

            // Checking for the right amout

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                    leftCounter++;
                else if (input[i] == ')')
                    rightCounter++;
            }
            if (leftCounter != rightCounter)
                return answers[0];

            // Checking for the right order

            for(int f = 0; f < input.Length; f++)
            {
                if (input[f] == ')' && leftSide == false)
                    return answers[2];
                else if (input[f] == '(')
                    leftSide = true;
                else if (input[f] == ')')
                    rightSide = true;
                else if (leftSide == true && rightSide == true)
                {
                    leftSide = false;
                    rightSide = false;
                }
                else if (f == input.Length - 1 && leftSide == true)
                    return answers[2];
            }

            return answers[1] + "\n" + answers[3];
        }
    }
}
