using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject asteroid;
    void Start()
    {
        StartCoroutine("SpawnAsteroids");
    }
    IEnumerator SpawnAsteroids()
    {  
        for (int i = 0; i< 5; i++)
        {
            Instantiate(asteroid, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0.5F);
        }
    }
}
