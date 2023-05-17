using SortMethod;

Console.Write("===============Welcome To Site ============= ");
Console.WriteLine("What Do you want ");
Console.WriteLine("press 1 for Sorting An Array ");
Console.WriteLine("press 2 for Sorting An String ");
int choice = Console.Read();
switch (choice)
{
    case 1: 
        Console.WriteLine("Enter size of Array");
        int size = System.Int32.Parse(Console.ReadLine());
        int [] arr = new int[size];

        Console.WriteLine(" Enter An Element of array ");
        for (int i = 0; i < size; i++)
        {   Console.WriteLine(" Enter the " +i+ " Element of array");
            arr[i] = System.Int32.Parse(Console.ReadLine());
        }

        Console.WriteLine(" Select sorting method ");
        Console.WriteLine(" 1) Selection sort ");
        Console.WriteLine(" 2) Bubble sort ");
        Console.WriteLine(" 3) Insertion sort ");
        Console.WriteLine(" 4) Quick sort ");
        Console.WriteLine(" 5) Merge sort ");
        
        int sortchoice = System.Int32.Parse(Console.ReadLine());
        Sort Sort = new Sort();
        switch (sortchoice)
        {
            case 1: 
                Sort.SelectionSort(arr);
                break;
            case 2: 
                Sort.BubbleSort(arr);
                break;
            case 3: 
                Sort.InsertionSort(arr);
                break;
            case 4:
                Sort.MergeSort(arr,0,arr.Length);
                break;
            case 5: 
                Sort.QuickSort(arr,0,arr.Length);
                break;
            default:
                System.Console.WriteLine(" Invalide choice ");
                break;
        }
        break;
        
    default:Console.WriteLine("Wrong Choice ");
    break;
}






