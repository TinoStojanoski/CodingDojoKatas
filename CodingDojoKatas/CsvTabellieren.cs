using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojoKatas
{
    internal class CsvTabellieren
    {

        public static void TabelleAusgeben()
        {
            IEnumerable<string> csvData = new List<string>
            {
                "Name;Strasse;Ort;Alter",
                "Peter Pan;Am Hang 5;12345 Einsam;42",
                "Maria Schmitz;Kölner Straße 45;50123 Köln;43",
                "Paul Meier;Münchener Weg 1;87654 München;65"
            };
            var csv = new CsvTabellieren().Tabelieren(csvData);
            

            foreach (var line in csv)
            {
                Console.WriteLine(line);
            }
        }
        
       public IEnumerable<string> Tabelieren(IEnumerable<string> csvZeilen)
        {

            List<List<string>> rows = csvZeilen
                .Select(row => row.Split(';').ToList())
                .ToList();

            int columnCount = rows.First().Count;
            int[] maxLengths = new int[columnCount];

            for (int i = 0; i < columnCount; i++)
            {
                maxLengths[i] = rows.Max(col => col[i].Length);
            }



            string header = string.Join(" | ", rows.First()
                .Select((col, i) => col.PadRight(maxLengths[i])));

            string separator = string.Join("+", maxLengths
                .Select(length => new string('-', length)));

            yield return header;
            yield return separator;

            foreach (var row in rows.Skip(1))
            {
                string formattedRow = string.Join(" | ", row
                    .Select((col, i) => col.PadRight(maxLengths[i])));
                yield return formattedRow;

            }
        }

    }
}