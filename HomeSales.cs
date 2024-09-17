using static System.Console;

// Danielle, Edward, and Francis are three salespeople at Holiday Homes. 
// Write an application named HomeSales that prompts the user for a salesperson initial (D, E, or F ). 
// Either uppercase or lowercase initials are valid. While the user does not type Z, 
// continue by prompting for the amount of a sale. Issue an error message for any invalid initials entered. 
// Keep a running total of the amounts sold by each salesperson. After the user types Z or z for an initial, 
// display each salesperson’s total, a grand total for all sales, and the name of the salesperson with the highest 
// total.

class HomeSales
{
    static void Main()
    {
       
        int danielSales= 0;
        int edwardsSales = 0;
        int francisSales = 0;


        while(true)
        {   
            
             WriteLine("What your initials? (D/E/F, type z/Z to end");
             string answer = ReadLine();

             if(answer.ToUpper() == "Z")
             {
                break;
             }
        
             WriteLine("Whats your sales Value: ");
            int amount = Convert.ToInt32(ReadLine());


            if (answer.ToUpper() =="D")
            {
                danielSales+= amount;
             }
            else if (answer.ToUpper() =="E")
            {
                edwardsSales+= amount;
             }
            else if (answer.ToUpper() =="F")
            {
                francisSales+= amount;
             }
             
        }
        

            WriteLine("Daniels Sales {0}", danielSales);
            WriteLine("Edwards Sales {0}" , edwardsSales);
            WriteLine("Francis Sales {0}", francisSales);

           

            int maxSales;
            string topSales;

            if(danielSales > edwardsSales && danielSales > francisSales )
            {
                maxSales = danielSales;
                 topSales = "Daniel";
            }
            else if (edwardsSales > danielSales && edwardsSales > francisSales)
            {
                maxSales = edwardsSales;
                topSales = "Edwards";
            }
            else 
            {
                maxSales = francisSales;
                topSales = "Francis";
            }
                WriteLine("Top Sales is {0} he has {1} Sales" ,topSales, maxSales);
                
    }
}