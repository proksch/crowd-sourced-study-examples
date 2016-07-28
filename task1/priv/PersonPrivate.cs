namespace task1.priv
{
   public  class PersonPrivate
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