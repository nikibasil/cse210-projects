using System;

public class Reference
{
    // ATTRIBUTES FROM THE CLASS. 
    // They are all setted to private.
    private string _book;
    private string _chapter;
    private string _verse1;
    private string _verse2;

    // CONSTRUCTORS  
    public Reference(string book, string chapter, string verse1, string verse2)
    {
        _book = book;
        _chapter = chapter;
        _verse1 = verse1;
        _verse2 = verse2;
    }

    public string GetReference()
    {
        string result;
        if (_verse2 != null)
        {
            result = $"{_book} {_chapter}:{_verse1}-{_verse2}";
        }
        else
        {
            result = $"{_book} {_chapter}:{_verse1}";
        }
        return result;
    }
}