using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class badCode
{
    public static string removeENTERdetexto(string strvalor)
    {
        string concat = "";

        string[] texto;
        if (strvalor.Contains("\n"))
        {
            texto = strvalor.Split('\n');
            foreach (string valor in texto)
            {
                concat += valor + " ";
            }
            return concat;
        }

        if (strvalor.Contains("\rn") || strvalor.Contains("\r"))
        {
            texto = strvalor.Split(new string[] { "\r\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string valor in texto)
            {
                concat += valor + " ";
            }
            return concat;
        }

        return strvalor;
    }
}

