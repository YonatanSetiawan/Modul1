using ProcessorKak;
namespace Modul1 
{
    class program
    {
        static void Main(string[] args)
        {
            Laptop Laptop1 = new Vivobook();
            Laptop1.vga = new Nvidia();
            Laptop1.processor = new CoreI5();
            Laptop laptop2 = new Idepad();
            laptop2.vga = new AMD();
            laptop2.processor = new Ryzen();
            Predator predator = new Predator();
            predator.vga = new AMD();
            predator.processor = new CoreI7();

            ////nomor 1
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();

            ////Nomor 2
            //Laptop1.Ngoding();

            //Nomor 3
            Console.WriteLine("Spesifikasi laptop \nMerk VGA: " + Laptop1.vga.merk + "\nMerk Processor: " + Laptop1.processor.merk + "\nTipe Processor: " + Laptop1.processor.tipe);

            ////Nomor 4
            predator.BermainGame();

            ////Nomor 5
            //ACER acer = new Predator();
            //acer.BermainGame();
        }
    }
}