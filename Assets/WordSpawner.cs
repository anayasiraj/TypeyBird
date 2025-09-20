using UnityEngine;

public class WordSpawner : MonoBehaviour
{

    /*
        Spawns and positions Word on UI display
    */

    [SerializeField] private GameObject wordPrefab;
    private Transform wordCanvas;

    void Awake()   // making sure it happens first so it spawns on canvas
    {
        wordCanvas = GameObject.FindGameObjectWithTag("Canvas").transform;
    }

    public WordDisplay SpawnWord()
    {
        GameObject wordObject = Instantiate(wordPrefab, wordCanvas);
        RectTransform rect = wordObject.GetComponent<RectTransform>();
        rect.anchoredPosition = new Vector2(0, 476);

        WordDisplay wordDisplay = wordObject.GetComponent<WordDisplay>();
        return wordDisplay;
    }
    
}
