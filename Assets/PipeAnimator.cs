using UnityEngine;

public class PipeAnimator : MonoBehaviour
{

    /*
        Animates pipe opening when player finishes typing the current word displayed
        Word given by WordManager
    */

    [SerializeField] private Animator animator;
    public Word word;  // fix

    void Awake()
    {
        word = null;
    }

    void Update()
    {
        if (word != null && word.WordTyped())
        {
            animator.SetBool("isOpen", true);
            word = null;
        }

    }
}
