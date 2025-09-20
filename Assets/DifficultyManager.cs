using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    /*
        Player can choose between 2 difficulties using buttons --> Easy or Hard
        Easy: words are 2-5 letters long
        Hard: words are 6+ letters long
        Default mode is Easy
        Saved in PlayerPrefs
    */

    [SerializeField] private AudioSource crying;

    void Awake()
    {
        if (!PlayerPrefs.HasKey("Difficulty"))
        {
            PlayerPrefs.SetInt("Difficulty", 0);   // default easy setting
            PlayerPrefs.Save();
        }
    }

    public void SetEasy()
    {
        PlayerPrefs.SetInt("Difficulty", 0);  // 0 = easy
        PlayerPrefs.Save();
        crying.Play();
    }

    public void SetHard()
    {
        PlayerPrefs.SetInt("Difficulty", 1);  // 1 = hard
        PlayerPrefs.Save();
    }


}
