using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeDataAndDoc
{
    class Program
    {

        static void Main(string[] args)
        {

            string inputFileName = "data.txt";
            string inputFileName1 = "template.txt";
            string outputFileName = "result.txt";
            if (args.Length == 6)
            {
                if (args[0] == "-i")
                {
                    inputFileName = args[1];
                    if (args[2] == "-t")
                    {
                        inputFileName1 = args[3];
                        if (args[4] == "-r")
                            outputFileName = args[5];
                    }
                    if (args[2] == "-r")
                    {
                        outputFileName = args[3];
                        if (args[4] == "-t")
                            inputFileName1 = args[5];
                    }
                }
                if (args[0] == "-t")
                {
                    inputFileName1 = args[1];
                    if (args[2] == "-r")
                    {
                        outputFileName = args[3];
                        if (args[4] == "-i")
                            inputFileName = args[5];
                    }
                    if (args[2] == "-i")
                    {
                        inputFileName = args[3];
                        if (args[4] == "-r")
                            outputFileName = args[5];
                    }
                }
                if (args[0] == "-r")
                {
                    outputFileName = args[1];
                    if (args[2] == "-t")
                    {
                        inputFileName1 = args[3];
                        if (args[4] == "-i")
                            inputFileName = args[5];
                    }
                    if (args[2] == "-i")
                    {
                        inputFileName = args[3];
                        if (args[4] == "-t")
                            inputFileName1 = args[5];
                    }
                }
            }

            using (StreamReader inputFile = new StreamReader(inputFileName, Encoding.Default))
            using (StreamReader inputFile1 = new StreamReader(inputFileName1, Encoding.Default))
            using (StreamWriter outputFile = new StreamWriter(outputFileName))
            {

                StringMethod(inputFile, inputFile1, outputFile);
            }
        }

        public static void StringMethod(TextReader inputFile, TextReader inputFile1, TextWriter outputFile)
        {
            string line; //test  
            string line2;
            string line3;
            string line4;
            line2 = inputFile1.ReadLine();
            line3 = inputFile1.ReadLine();
            line4 = inputFile1.ReadLine();

            while ((line = inputFile.ReadLine()) != null)
            {
                string[] lin1 = line.Split(new char[] { '\t' });//分割字符
                string lin2 = line2.Replace("${中文姓名}", lin1[0]).Replace("${身份证字号}", lin1[1]).Replace("${年数}", lin1[2]);
                Console.WriteLine(lin2);
                Console.WriteLine(line3);
                Console.WriteLine(line4);
                outputFile.WriteLine(lin2);
                outputFile.WriteLine(line3);
                outputFile.WriteLine(line4);
            }
        }

    }
}