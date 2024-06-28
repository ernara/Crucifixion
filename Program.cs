using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using Crucifixion;

class Program
{
    static void Main()
    {
        Logic.Setup();
        Logic.DeleteWordsFrom5();
        Logic.DeleteWordsFrom9();
       
        for (int i = 0; i < 4; i++)
        {
            Logic.Fix([0,7], [7], [2]);
            Logic.Fix([1,9], [1], [1]);
            Logic.Fix([2,7,8,9], [2,4,6], [4,0,3]);
            Logic.Fix([3,6,7], [2,5], [0,6]);
            Logic.Fix([4,8,9], [0,2], [2,5]);
            Logic.Fix([5,6,7,8,9], [1, 4, 6, 8], [2,8,4,7] );
            Logic.Fix([6,3,5], [0,2], [2,1]);
            Logic.Fix([7,0], [2], [7]);
            Logic.Fix([8,2,4,5], [0,2,4], [4,0,6]);
            Logic.Fix([9,1,2,4,5], [1,3,5,7], [1,6,2,8]);
            Logic.RemoveNotNeeded();
            Logic.WordsLeft();
        }
        Logic.WriteAnswerWords();
    }
}
