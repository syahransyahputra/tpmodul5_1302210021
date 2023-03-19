// See https://aka.ms/new-console-template for more information

public class program
{
    public static void Main(string[] args)
    {
        DataGeneric<string> data = new DataGeneric<string>("1302210021");
        data.printData();
    }

    class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void printData()
        {
            Console.WriteLine("data yang tersimpan adalah: " + data);
        }
    }
}
