using System;
using System.Text.RegularExpressions;

namespace Baithi_HAH.Models.StringProcess
{
    public string StringProcess
    
        public String AutoGenerateCode(string strInput)
        {
            string numPart="", strPart="", strResult="" ;
            numPart = Regex.Match(Convert.ToString(@"\d+")).Value;
            strPart = Regex.Match(Convert.ToString(@"\D+")).Value;
            int intPart = (numPart) + 1 ;
            for( int i=0; strPart.Length - (ToInt32.intPart).Length  ;i++)
            {
                strResult +="0";
            }
            return strResult;
        }
    
}