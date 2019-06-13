using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtables
{
    class JSONParser
    {

        public static int[] jsonToIntArr(object JSON)
        {
            string jsonStr = Convert.ToString(JSON);

            jsonStr = jsonStr.Trim(' ', '{', '"','}',  'I', 'd', 's', ':', '[', ']');
            string[] jsonSplit = jsonStr.Split(',');

            int[] tempArr = new int[jsonSplit.Length];
            for (int i = 0; i < jsonSplit.Length; i++)
            {
                jsonSplit[i].Trim(' ', '"');
                if (jsonSplit[i] != "")
                {
                    tempArr[i] = Convert.ToInt32(jsonSplit[i]);
                    Console.WriteLine(tempArr);
                }

            }

            List<int> a = new List<int>();
            foreach(int j in tempArr)
            {
                if(j != 0)
                    {
                    a.Add(j);
                    }
            }
            return a.ToArray();
        }
    }
}
