using System.Linq;
using System.Collections.Generic;
using System;
using System.Collections;

namespace video3
{
    class Program
    {
        static void Main(string[] args)
        {
            int lessonNumber = 4;

            DisplayLessonNumber(lessonNumber);

            DisplayLessonNumberAsString($"Video {lessonNumber} Lesson");

            string lessonNumberFormatted = DisplayLessonNumberFormatted(lessonNumber);
            
            Console.WriteLine(lessonNumberFormatted);
        }

        static void DisplayLessonNumber(int lessonNumber)
        {
            Console.WriteLine($"DisplayLessonNumber: Video {lessonNumber} Lesson");
        }

        static void DisplayLessonNumberAsString(string lesson)
        {
            Console.WriteLine($"DisplayLessonNumberAsString: {lesson}");
        }

        static string DisplayLessonNumberFormatted(int lessonNumber)
        {
            return $"DisplayLessonNumberFormatted: Video {lessonNumber} Lesson";
        }
    }
}
