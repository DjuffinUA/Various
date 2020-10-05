using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel_v1._2
{
    class Table
    {
        public string RefDes { get; set; }
        public string Name { get; set; }
        public string Pattern { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public string Side { get; set; }
        public string Rotate { get; set; }
        public string Value { get; set; }
        public string ToCsvRow()
        {
            return $"{RefDes};{Name};{Pattern};{X};{Y};{Side};{Rotate};{Value}";
        }

        public static Table FromCsvRow(string csvRow)
        {
            var props = csvRow.Split(';');
            return new Table()
            {
                RefDes = props[0],
                Name = props[1],
                Pattern = props[2],
                X = props[3],
                Y = props[4],
                Side = props[5],
                Rotate = props[6],
                Value = props[7]
            };
        }
    }
}
