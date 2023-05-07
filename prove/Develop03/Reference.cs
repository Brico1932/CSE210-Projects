using System;

public class Reference
{
    public string book;
    public string chapter;
    public string verseStart;
    public string verseEnd;
    public Reference(string _book, string _chapter, string _singleVerse)
    {
        book = _book;
        chapter = _chapter;
        verseStart = _singleVerse;
        verseEnd = "";
    }

    public Reference(string _book, string _chapter, string _verseStart, string _verseEnd)
    {
        book = _book;
        chapter = _chapter;
        verseStart = _verseStart;
        verseEnd = _verseEnd;
    }

    public string GetReference()
    {
        if (verseEnd == "")
        {
            return ($"{book} {chapter}: {verseStart}");
        }
        else
        {
            return ($"{book} {chapter}: {verseStart}-{verseEnd}");
        }
    }
}