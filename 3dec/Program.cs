using System.IO;

char? chr;

StreamReader sr = new StreamReader("C:\\Users\\starw\\Desktop\\Egna projekt\\AdventOfCode2024\\3dec\\example.txt");
// char chr = (char)sr.Read();
try
{
    int? total = 0;
    while(sr.Peek() >= 0){
        
        chr = (char)sr.Read();

        if(chr == 'm')
        {
            chr = (char)sr.Read();
            if(chr == 'u')
            {
                chr = (char)sr.Read();
                if(chr == 'l')
                {
                    chr = (char)sr.Read();
                    if(chr == '(')
                    {
                        //om nån får felaktig input, sätt till 0- detta bortser från totalen
                        int nbr1 = getNbr(sr);
                        int nbr2 = getNbr(sr);
                        total+= nbr1*nbr2;
                    }
                }
            }
        }
        Console.WriteLine(chr);

    }
}catch(Exception e)
{
    throw(e);
}


int getNbr(StreamReader inp)
{
    try{
        //medans nästa karaktär är en int, fortsätt bygg numret: annars, returnera.
        while(inp.)
        return 0;
    }catch(Exception e)
    {
        throw(e);   
    }
    
}