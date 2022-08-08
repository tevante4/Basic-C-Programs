using System;

public class Class1
{
	public Class1()
	{
	}
    public static void CheckUnique(List<string> ilist)
    {

        List<string> ulist = new List<string>();
        foreach (string str in ilist)
        {

            if (ulist.Contains(str))
                Console.WriteLine("{0} - item is a duplicate", str);
            else
            {
                ulist.Add(str);
                Console.WriteLine("{0}- item is unique", str);
            }
        }


    }
}
