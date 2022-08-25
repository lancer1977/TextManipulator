using System;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Generator.Core
{
    public class ListToolsViewModel
    {
        public static string CondenseEnums(string value)
        {
            var myList = value.Split(',');
            return string.Join(",\n", myList.Distinct());
        }

        public static string CsvToDelimitedString(  string value, char join)
        {
            if (string.IsNullOrEmpty(value)) return string.Empty;
            var myList = value.Split(',');
            return string.Join(join.ToString(), myList.Distinct());
        }

        public string NewLineToCSV(string value)
        {
            var myList = value.Split('\n');
            return string.Join(",", myList.Distinct());
        }
    }
    public class DataViewModel
    {
        public string FormatSpells(string info)
        {
            try
            {
                for (var x = 0; x < 10; x++)
                {
                    info =
                        info.Replace("9th", "\n").Replace("8th", "\n").Replace("7th", "\n").Replace("6th", "\n").Replace(
                                "5th", "\n").Replace("4th", "\n").Replace("3rd", "\n").Replace("2nd", "\n")
                            .Replace("1st", "\n")
                            .Replace("0 (at will)", "\n");
                     
                }
            }
            catch (Exception ex)
            {

            }

            return info;
        }
         

    }
    public class BufferViewModel
    {
        public string Generate(string name, (string, string)[] items)
        {
            var strAdd = "\"Case \"{x}\"\nif straction = \"Add\" then\n"; 
            foreach (  var (x, y) in items)
            {
                strAdd += $"f sender.{x} < {y} then sender.{x} = {y}\n";
            }
            strAdd = "else \n";
            foreach (var (x, y) in items)
            {
                strAdd += $"if sender.{x} < {y} then sender.{x} = {y}\n";
            }

            strAdd += "end If";
            return strAdd;

        }
    }
}
