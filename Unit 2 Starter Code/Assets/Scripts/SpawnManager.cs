using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] meteorPrefab;
    // Start is called before the first frame update
    void Start()
    {
        // call the spawnmeteors function every so often
        InvokeRepeating("SpawnMeteors", 0.5f, 1.5f);
    }

    // this function will randomly spawn meteors in my scene
    private void SpawnMeteors()
    {
        // generate a random value from -70 to 70
        float randomX = Random.Range(-70f, 70f);

        //generate a random meteor
        GameObject meteor = meteorPrefab[Random.Range(0, meteorPrefab.Length)];

        //spawn a meteor at a specific position
        Instantiate(meteor, new Vector3(randomX, 0.5f, 45f), meteor.transform.rotation);
    }
}
