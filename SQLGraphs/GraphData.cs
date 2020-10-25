using System;
using System.Collections.Generic;
using System.Data;

namespace DbUtils
{
    public class GraphData
    {
        public DataTable Table { get; }
        public string Name { get; }

        public GraphData(List<int> xvals, List<int> yvals, string name)
        {
            this.Name = name;
            this.Table = MakeDataSetFromList(xvals, yvals, name);
        }
        
        public DataTable MakeDataSetFromList(List<int> xvals, List<int> yvals, string seriesName)
        {
            DataTable data = new DataTable("Name");
            DataColumn col;




            return data;
        }
    }
}