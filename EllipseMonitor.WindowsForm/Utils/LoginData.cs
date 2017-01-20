using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EllipseMonitor.WindowsForm.Utils
{
    public class LoginData
    {

        private List<AzureCredentials> azureList;

        public List<AzureCredentials> AzureList
        {
            get
            {
                return azureList;
            }
            set
            {
                azureList = value;
            }
        }
        public LoginData(string filePath)
        {
            int lineCounter = 0; 
            if (System.IO.File.Exists(filePath) == true)
            {
                System.IO.StreamReader objReader;
                objReader = new System.IO.StreamReader(filePath);

                AzureList = new List<AzureCredentials>();
                do
                {
                    var line = objReader.ReadLine();
                    lineCounter++;
                    if (lineCounter == 1)
                    {
                        continue;
                    }
                    //Split string by comma
                    List<string> values = line.Split(',').ToList<string>();

                    var azureCredentials = new AzureCredentials(values[0], values[1], values[2], values[3], values[4], values[5]);
                    AzureList.Add(azureCredentials);

                } while (objReader.Peek() != -1);

            }

        }
    }
}
