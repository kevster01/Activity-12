using System;


namespace Program 
{


    public class Kevin
    {
    
    
    
         public static void Main()
            {

            int wrd, l;

      
            string  str = System.IO.File.ReadAllText("text3.txt");
       

            l = 1;
            wrd = 1;

    
             while (l <= str.Length - 1)
             { 
    
       
                if((str[l]=='.' || str[l]== ' ' || str[l]=='\t' || str[l] == '!' || str[l] == ','||str[l] == '?'|| str[l] == '\n') && (str[l-1] == 't' || str[l-1] == 'e'))
                {
                    wrd++;
                 }
        

                     l++;
             }

            Console.Write("There are {0} words ending in t or e", wrd);
         }


    }
}