using UnityEngine;

public class InitialVelocity : MonoBehaviour
{

    /*
        Makes floaty letters disperse in random directions upon opening Title Scene
    */

    private float speed = 3f;

    void Start()
    {
        var rb = GetComponent<Rigidbody2D>();
        Vector2 direction = new Vector2(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f)
        ).normalized;
        rb.linearVelocity = direction * speed;
    }

}
