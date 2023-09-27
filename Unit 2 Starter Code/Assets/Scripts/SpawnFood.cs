using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public GameObject[] foodPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0.5f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Spawn()
    {
        float randomX = Random.Range(-30f, 10f);

        GameObject food = foodPrefab[Random.Range(0, foodPrefab.Length)];
        Instantiate(food, new Vector3(randomX, transform.position.y, transform.position.z), food.transform.rotation);


    }
}
