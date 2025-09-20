using UnityEngine;

public class PipeMover : MonoBehaviour
{

    /*
        Handles speed of spawned pipes
        Deletes pipes once they reach dead zone offscreen
    */

    [SerializeField] private float moveSpeed = 5;
    [SerializeField] private float deadZone = -40;

    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;  // LETS DEPEND ON FPS!!! DIFF

        if (transform.position.x < deadZone)  // delete pipe once it's off screen
        {
            Destroy(gameObject);     
        }
    }
}
