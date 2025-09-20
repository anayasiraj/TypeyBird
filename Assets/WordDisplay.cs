using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class WordDisplay : MonoBehaviour
{

    /*
        Accesses and changes text displayed on screen for each Word
    */

    [SerializeField] private TextMeshProUGUI text;


    public void SetWord(string word)
    {
        text.text = word;
    }

    public string GetWordString()
    {
        return text.text;
    }

    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }




}
