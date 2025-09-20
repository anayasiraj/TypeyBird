using UnityEngine;

public class MiddlePipeScript : MonoBehaviour
{

    /*
        Uses logic function to add to score when bird passes through a pipe (trigger)
    */

    private Logic logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();   // same as dragging dropping
    }

    private void OnTriggerEnter2D (Collider2D collision)  // when object FIRST hits collider
    {
        if (collision.gameObject.layer == 3)  // if collision happened on bird layer (FUTURE PROOFING)
        {
            logic.AddScore(1);
        }
        
    }

}
