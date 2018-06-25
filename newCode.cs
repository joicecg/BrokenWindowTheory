class newCode
{
    public static string removeEnter(string strText)
    {
        string[] verify = { "\n", "\r", "\r\n" };
        foreach (string enter in verify)
        {
            if (strText.Contains(enter))
            {
                strText = strText.Replace(enter, " ");
            }
        }      
        
        return strText;
    }
}

