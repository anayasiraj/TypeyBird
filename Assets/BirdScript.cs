using UnityEngine;

public class BirdScript : MonoBehaviour
{

    /*
        Handles bird being alive or not (collision, out of bounds) and movement 
        Ends game if bird dies
    */

    [SerializeField] private Rigidbody2D myRigidBody;
    [SerializeField] private float flapStrength;   // how high bird goes when space is pressed
    private Logic logic;
    [SerializeField] private bool birdIsAlive = true;
    [SerializeField] private AudioSource flapSound;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    void Update()
    {

        // bird flies upward when space pressed ONLY if alive
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidBody.linearVelocity = Vector2.up * flapStrength;
            flapSound.Play();
        }

        // end game if bird goes out of bounds
        if (birdIsAlive && (transform.position.y > 17 || transform.position.y < -17))
        {
            birdIsAlive = false;
            logic.GameOver();

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // end game if bird touches pipe
        if (birdIsAlive)
        {
            birdIsAlive = false;
            logic.GameOver();
        }

    }


}
