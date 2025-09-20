using UnityEngine;


[System.Serializable]
public class Word
{

    /*
        Word class prefab
        Each Word is given a string and a display for UI
        TypeIndex begins at 0 (the letter the player is on)
        Deletes letters from display as player types them
        Deletes Word from screen once player has completed typing it
    */

    private string wordString;
    private int typeIndex;
    WordDisplay display;

    public Word(string myWord, WordDisplay myDisplay)
    {
        wordString = myWord;
        typeIndex = 0;

        display = myDisplay;
        display.SetWord(myWord); 
    }


    public char GetNextLetter()
    {
        return wordString[typeIndex];
    }

    public void TypeLetter()
    {
        typeIndex++;
        display.RemoveLetter();
    }

    // true if player finishes the word --> destroys itself
    public bool WordTyped()
    {
        bool typed = (typeIndex >= wordString.Length);
        if (typed && display != null)    // only works if word is typed and not destroyed yet
        {
            display.RemoveWord();
            display = null;
        }

        return typed;
    }

}
