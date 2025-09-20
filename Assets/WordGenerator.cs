using UnityEngine;


public class WordGenerator
{

    /*
        Gives Word a random word from an array
        Chooses between Easy and Hard arrays based on PlayerPrefs
        Easy: words with 3-5 letters
        Hard: words with 6+ letters
    */

    private static string[] easy = {"bird", "fly", "beak", "wing", "flap", "feet", "tweet", "tail", "duck", "hawk", "goose", "owl",
        "finch", "eagle", "crane", "crow", "raven", "macaw", "robin", "stork", "dove", "emu", "seeds", "sing", "chirp", "caw"};
    private static string[] hard = {"feather", "feathers", "talons", "flamingo", "sparrow", "pelican", "canary", "bluejay", "pigeon",
        "peacock", "sparrow", "cuckoo", "cardinal", "condor", "vulture", "parakeet"};


    public static string GetRandomWord()
    {
        string randomWord = " ";
        int difficulty = PlayerPrefs.GetInt("Difficulty", 0);
        if (difficulty == 0)
        {
            int randomIndex = Random.Range(0, easy.Length);
            randomWord = easy[randomIndex];
        }
        else if (difficulty == 1)
        {
            int randomIndex = Random.Range(0, hard.Length);
            randomWord = hard[randomIndex];
        }

        return randomWord;
    }

}
