using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    /*
        Spawns pipes using pipe prefab using timer
        Randomizes y-position, so opening height is random
    */

    [SerializeField] private GameObject pipe;    // prefab

    [SerializeField] private float spawnRate = 5;    // space between pipe spawns
    private float timer = 0;

    [SerializeField] private float heightOffset = 8;   // maximums for height


    void Start()
    {
        SpawnPipe();
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;   // fps
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }

    }

    void SpawnPipe()
    {
        float lowest = transform.position.y - heightOffset;
        float highest = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowest, highest), 0), transform.rotation);
    }


}
