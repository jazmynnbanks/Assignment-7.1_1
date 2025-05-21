int[] myGrades = { 85, 92, 76, 100, 79, 82, 94, 96 };

Console.WriteLine("Original order: ");
foreach (int grade in myGrades)
{
    Console.Write(grade + " ");
}
Console.WriteLine();

for (int i = 0; i < myGrades.Length - 1; i++)
{
    int minIndex = i;
    for (int j = i + 1; j < myGrades.Length; j++)
    {
        if (myGrades[j] < myGrades[minIndex])
        {
            minIndex = j;
        }
    }
    int temp = myGrades[minIndex];
    myGrades[minIndex] = myGrades[i];
    myGrades[i] = temp;
}

Console.WriteLine("\nNew order:");
foreach (int grade in myGrades)
{
    Console.Write(grade + " ");
}

Console.ReadKey();



