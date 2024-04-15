namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\smdsh\\source\\repos\\2024-04-15-BL-InclassReview-Regex,FileIO&MSTest\\FileIO\\Text.txt";
            if (File.Exists(filePath))
            {
                Console.WriteLine("File already exists and the file content is as follows");
                Console.WriteLine(File.ReadAllText(filePath));
                return;
            }
            else
            {
                string[] contentToAdd =
                {
                    "First Line",
                    "Second Line",
                    "Third Line"
                };
                File.Create(filePath).Close();
                File.AppendAllLines(filePath, contentToAdd);
                Console.WriteLine("A new file is created");
            }
        }
    }
}
