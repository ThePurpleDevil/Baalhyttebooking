namespace Baalhyttebooking
{

    public class Program
    {
        

             static void Main(string[] args)
             {
            boernegruppe Bg = new boernegruppe("ørne", "fulgeunger", "pusling", 5);
            DateTime dt2 = new DateTime(2023, 12, 31);
            Reservation Res = new Reservation(21, dt2);

            Console.WriteLine($"her er første gruppe \n{Bg}");
            Console.WriteLine($"her er Reservations bekæft {Res}");
             }
           
        
    }
}
