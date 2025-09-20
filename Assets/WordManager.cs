using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{

    /*
        Adds and displays Words in screen when game starts and when player gets through a pipe
    */

    private Word activeWord;
    private Logic logic;
    private int curScore = 0;
    private PipeAnimator pipeAnimator;
    [SerializeField] private WordSpawner wordSpawner;


    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
        pipeAnimator = FindObjectOfType<PipeAnimator>();
        AddWord();
    }

    void Update()
    {
        if (curScore < logic.GetScore())    // spawn word every time player goes through pipe
        {
            curScore++;
            AddWord();
        }
    }

    public Word GetWord()
    {
        return activeWord;
    }

    public void AddWord()
    {
        WordDisplay wordDisplay = wordSpawner.SpawnWord();
        Word word = new Word(WordGenerator.GetRandomWord(), wordDisplay);
        activeWord = word;
        pipeAnimator = FindObjectOfType<PipeAnimator>();
        pipeAnimator.word = activeWord;

    }

    // takes in input and calls to remove letter from screen if player typed the correct letter
    public void TypeLetter(char letter)
    {
        if (!activeWord.WordTyped())    // only if the word isn't done being typed yet
        {
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
    }


}
