using System;
using Microsoft.Data.SqlClient;

namespace DbUtils
{
    public class SubjectEntry
    {
        public string fixedAcidity { get; }
        public string volatileAcidity { get; }
        public string citricAcid { get; }
        public string sugar { get; }
        public string chlorides { get; }
        public string freeSO2 { get; }
        public string totalSO2 { get; }
        public string density { get; }
        public string ph { get; }
        public string sulphates { get; }
        public string alcohol { get; }
        public string quality { get; }
        public string subjectId { get; }

        public SubjectEntry(SqlDataReader reader)
        {
            try
            {
                this.fixedAcidity = reader.GetString(0);
                this.volatileAcidity = reader.GetString(1);
                this.citricAcid = reader.GetString(2);
                this.sugar = reader.GetString(3);
                this.chlorides = reader.GetString(4);
                this.freeSO2 = reader.GetString(5);
                this.totalSO2 = reader.GetString(6);
                this.density = reader.GetString(7);
                this.ph = reader.GetString(8);
                this.sulphates = reader.GetString(9);
                this.alcohol = reader.GetString(10);
                this.quality = reader.GetString(11);
                this.subjectId = reader.GetString(12);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void print()
        {
            Console.Write(fixedAcidity); Console.Write(" ");
            Console.Write(volatileAcidity); Console.Write(" ");
            Console.Write(citricAcid); Console.Write(" ");
            Console.Write(sugar); Console.Write(" ");
            Console.Write(chlorides); Console.Write(" ");
            Console.Write(freeSO2); Console.Write(" ");
            Console.Write(totalSO2); Console.Write(" ");
            Console.Write(density); Console.Write(" ");
            Console.Write(ph); Console.Write(" ");
            Console.Write(sulphates); Console.Write(" ");
            Console.Write(alcohol); Console.Write(" ");
            Console.Write(quality); Console.Write(" ");
            Console.Write(subjectId); Console.Write(" ");
            Console.WriteLine();
        }
    }
}
