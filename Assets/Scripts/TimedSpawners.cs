using System.Collections;
using UnityEngine;

public class TimedSpawners : MonoBehaviour
{
    [SerializeField] protected GameObject perfabToSpawn;
    [SerializeField] protected float secondsBetweenSpawns = 1f;

    // Start is called before the first frame update
    void Start()
    {
        this.StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            Debug.Log("secondsBetweenSpawns: " + secondsBetweenSpawns);
            Instantiate(perfabToSpawn, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(secondsBetweenSpawns);
        }
    }
}
