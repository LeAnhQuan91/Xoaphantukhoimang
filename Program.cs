internal class Program
{
    private static void Main(string[] args)
    {
        int[] myArray = {1,2,3,4,5,6,7,8,9};
        Console.WriteLine("Nhap gia tri can xoa");
        int x = Convert.ToInt32(Console.ReadLine());
        ClearArray(x,myArray);
        
        }
        private static void ClearArray(int x,int[])
        {
        int indext =0;
        //Tim gia tri da nhap trong mang
        for (int i =0; i<myArray.Length; i++)
        {
            if (myArray[i]==x)
{
    indext=i;
}
        }
        // chen phan tu da nhap tai vi tri indext
        for (int i= indext; i<myArray.Length-1;i++)
        {
myArray[i]=myArray[i+1];
        }
        //thay doi kich thuoc phan tu mang
        Array.Resize(ref myArray,myArray.Length-1);
        for(int i = 0;i <myArray.Length;i++)
        {
            Console.Write(myArray[i]+",");
        }
}
}
