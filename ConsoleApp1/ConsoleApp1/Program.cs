String line;
try
{
    
    StreamReader sr = new StreamReader("C:\\Users\\Artem\\OneDrive\\Abra\\SE1_1.gfc");
    
    line = sr.ReadLine();

    int n = 16;
    int m = 16;

    double[,] arrayG = new double[n, m];
    double[,] arrayH = new double[n, m];
    
    while (line != null)
    {
        
        string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        line = sr.ReadLine();

        if (words.Length < 1)
            continue;
            
        if (!words[0].Equals("gfc"))
            continue;

        words[3] = words[3].Replace(".", ",");
        words[4] = words[4].Replace(".", ",");
        
        arrayG[int.Parse(words[1]), int.Parse(words[2])] = double.Parse(words[3]);
        arrayH[int.Parse(words[1]), int.Parse(words[2])] = double.Parse(words[4]);
        //Console.WriteLine(arrayG[int.Parse(words[1]), int.Parse(words[2])].ToString());
        Console.WriteLine(line);


    }

    // Console.WriteLine(arrayG[6, 0].ToString("0.#########################"));


    Console.WriteLine("Salam");
    double g = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 1; j < n; j++)
        {
            Console.WriteLine(arrayH[i, j]);
        }
    }
    //close the file
    sr.Close();
    Console.ReadLine();
}
catch(Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
}
finally
{
    Console.WriteLine("Executing finally block.");
}