using System.IO;

class ReadFromFile
{
    public List<List<int>> GetFromFileMethod()
    {
        String? line;
        List<List<int>> list = new List<List<int>>();

        try
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader("C://Users//starw//Desktop//Egna projekt//AdventOfCode2024//dec2//input.txt");
            // StreamReader sr = new StreamReader("C://Users//starw//Desktop//Egna projekt//AdventOfCode2024//dec2//exampleInput.txt");
            //Read the first line of text
            line = sr.ReadLine();
                              //Continue to read until you reach end of file
            while (line != null)
            {
                List<int> temp = new List<int>();
                String[] splitted = line.Split(" ");
                foreach(String element in splitted)
                {
                    temp.Add(int.Parse(element));
                }
                //write the line to console window
                //Read the next line
                list.Add(temp);
                line = sr.ReadLine();
            }
            sr.Close();
            return list;
            //close the file
            //Console.ReadLine();
            }
        catch(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
            return list;
        }
    }
}
