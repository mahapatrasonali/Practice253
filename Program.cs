namespace AddDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            try 
            {
                int a = 12;
                int b = 0;
                int c = a / b;
                int[] arr = new int[4];
                arr[0]= 3;
                arr[1] = 34;
                arr[2] = 45;
                arr[3] = 54;
                arr[4] = 67;

                for (int i =0;i<4;i++)
                {
                    Console.WriteLine("arr[i]");
                }
            }catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("The program is Executed");
            }
        }
    }
}
