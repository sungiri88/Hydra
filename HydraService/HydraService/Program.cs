using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using CsvHelper;
using System.Configuration;

namespace HydraService
{
    class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
            string FilePath = ConfigurationManager.AppSettings["CSVFilePath"];
            #region Import Keyword List
            //app.UpdateKeywordListFromCSV(FilePath);
            #endregion
            #region Process Rules
            List<FieldInfo> CSVDataList = app.GetCSVData(FilePath);
            var SummaryData = CSVDataList.FindKeyword("Summary", 0);
            var ClassAData = CSVDataList.FindKeywordAfterSpecificLine("Class A-2B Notes", SummaryData.LineNumber, 1);
            #endregion
        }
    }
}
