class additionalCode
{
    public string removeEnterAndSpaces(string strText)
    {
        string[] verify = { "\n", "\r", "\r\n" };
        foreach (string enter in verify)
        {
            if (strText.Contains(enter))
            {
                strText = strText.Replace(enter, " ");
            }
        }

        while (strText.Contains("  "))
        {
            strText = strText.Replace("  ", " ");
        }

        return strText;
    }
}

