using UnityEngine;

public class MousePusher : MonoBehaviour
{
    /*
        Uses mouse position to move collider around
        Pushes around floaty letters in Title Scene
        Might add sound effects lol
    */

    [SerializeField] private Camera cam;

    void Update()
    {
        Vector3 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0; // keep 2D
        transform.position = mousePosition;

    }
}
