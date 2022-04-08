


using System;
using System.IO;

namespace LogFileAssign18Feb
{
    /// <summary>
    /// Class for log file handling
    /// </summary>
    internal class Func
    {
        internal bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Read Log File");
            Console.WriteLine("2) Write Log File");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");
            string res = Console.ReadLine().Trim();

            try
            {
                switch (Convert.ToInt16(res))
                {
                    case 1:
                        this.readFile();
                        return true;
                    case 2:
                        this.writeFile();
                        return true;
                    case 3:
                        return false;
                    default:
                        Console.WriteLine("Please enter option(1 or 2 or 3!");
                        Console.WriteLine("Press any Key!");
                        Console.ReadKey();
                        return true;
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Error occured! Please enter 1, 2 or 3 ");
                Console.WriteLine("Press any Key!");
                Console.ReadKey();
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter option 1, 2 or 3!");
                Console.WriteLine("Press any Key!");
                Console.ReadKey();
                return true;

            }

        }
        internal void readFile()
        {
            char resRF;
            try
            {
                if (File.Exists("LogFile.txt"))
                {
                    // Read a text file line by line.  
                    string[] lines = File.ReadAllLines("LogFile.txt");
                    foreach (string line in lines)
                        Console.WriteLine(line);
                    Console.WriteLine("Press any Key!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("File doesn't exist!");
                    Console.WriteLine("Do you want to create log file? (Y or N)");
                    resRF = Console.ReadKey().KeyChar;
                    if (resRF == 'Y')
                    {
                        this.writeFile();
                        return;
                    }
                    else if (resRF == 'N')
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Please enter Y or N!");

                        Console.ReadKey();
                    }
                }
            }
            catch (IOException io)
            {
                Console.WriteLine("Error occured " + io.Message);
            }

        }

        internal void writeFile()
        {
            try
            {

                FileInfo f1 = new FileInfo("LogFile.txt");

                StreamWriter sw = f1.AppendText();
                //Get a StreamWriter for the file


                Console.Write("Please enter remarks to be added to log file:");

                //Get the name from the console
                string remarks = Console.ReadLine();

                //Write to file
                sw.WriteLine("User Name:" + System.Security.Principal.WindowsIdentity.GetCurrent().Name);
                sw.WriteLine("Remarks :" + remarks);

                sw.WriteLine("Current Date time :" + DateTime.Now);
                Console.WriteLine("Information Saved!");
                Console.WriteLine();

                //Close the writer and file
                sw.Close();
                Console.WriteLine("Press any Key!");
                Console.ReadKey();
            }
            catch (IOException e)
            {
                Console.WriteLine("An IO Exception Occurred :" + e);
            }
        }
    }
}