using UnityEngine;

public class WordInput : MonoBehaviour
{

    /*
        Takes player input, converts to chars for WordManager's TypeLetter function
    */

    [SerializeField] private WordManager wordManager;

    void Update()
    {
        foreach (char letter in Input.inputString)
        {
            wordManager.TypeLetter(letter);
        }
    }
    
}
