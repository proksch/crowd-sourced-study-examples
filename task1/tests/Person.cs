﻿namespace task1.tests
{
   public  class Person
   {
       public string Name { get; set; }
       public Gender Gender { get; set; }
       public int Age { get; set; }
   }

   public enum Gender
   {
       Male, Female, Other
   }
}