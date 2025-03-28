namespace Task_21_06
{
    //Написать метод, который удаляет повторяющиеся элементы из списка, сохраняя порядок.
    internal class Program
    {
        static List<int> RemoveDuplicates(List<int> numbers)
        {
            HashSet<int> seen = new HashSet<int>();
            List<int> uniqueList = new List<int>();

            foreach (int num in numbers)
            {
                if (!seen.Contains(num))
                {
                    seen.Add(num);
                    uniqueList.Add(num);
                }
            }

            return uniqueList;
        }

        static void Main()
        {
            List<int> nums = new List<int> { 1, 2, 2, 3, 4, 4, 5, 6, 6 };
            List<int> uniqueNums = RemoveDuplicates(nums);

            Console.WriteLine("Список без повторов: " + string.Join(", ", uniqueNums));
        }
    }
}
