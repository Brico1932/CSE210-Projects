using System;

public class Scripture
{
    private List<Word> words;
    private  Reference scriptureReference;

    public Scripture(Reference _scriptureReference, string _scriptureText)
    {
        scriptureReference = _scriptureReference;
        words = new List<Word>();
        CreateWords(_scriptureText); 
    }
    public void HideWord()
    {
        int numWordsToHide = new Random().Next(2,4);
        int wordsHidden = 0;

        do
        {
            int randomWordIndex = new Random().Next(0, words.Count());
            if(words[randomWordIndex].GetIsHidden() == false)
            {
                words[randomWordIndex].SetIsHidden(true);
                wordsHidden++;
            }
        }while (wordsHidden != numWordsToHide && this.HasWordsLeft());
    }

    private void CreateWords(string _scriptureText)
    {
        List<string> allWords = _scriptureText.Split(' ').ToList();
        foreach (string i in allWords)
        {
            Word word = new Word(i);
            words.Add(word);
        }
    }

    public string GetScripture()
    {
        string scriptureText = "";
        foreach(Word word in words)
        {
            if(word.GetIsHidden() == false)
            {
                scriptureText += word.GetWord() + " ";
            }
            else
            {
                scriptureText += new string('_', word.GetWord().Length) + " ";
            }
        }
        return ($"{scriptureReference.GetReference()} {scriptureText}");
    }
    public bool HasWordsLeft()
    {
        bool moreWords = false;
        foreach (Word word in words)
        {
            if(word.GetIsHidden()== false)
            {
                moreWords = true;
            }
        }
        return moreWords;
    }
}

