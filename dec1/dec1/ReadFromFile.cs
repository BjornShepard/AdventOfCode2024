using System.IO;

class ReadFromFile
{
    public List<List<int>> GetFromFileMethod()
    {
        String line;
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();
        List<List<int>> returnList = new List<List<int>>();
        try
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader("C://Users//starw//Desktop//Egna projekt//AdventOfCode2024//dec1//dec1//input.txt");
            //Read the first line of text
            line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                String[] splitted = line.Split("   ");
                list1.Add(int.Parse(splitted[0]));
                list2.Add(int.Parse(splitted[1]));
                //write the line to console window
                //Read the next line
                line = sr.ReadLine();
            }

            returnList.Add(list1);
            returnList.Add(list2);
            sr.Close();
            return returnList; 

            //close the file
            //Console.ReadLine();
            }
        catch(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
            return null;
        }
    }
}