using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionTest : MonoBehaviour
{
    /*
    //private int[] arraytest1;
    [SerializeField]
    private int[] enteros = new int[5];

    [SerializeField]
    private Chest[] arraytest2 = new Chest[8];
    */

    /*
    [SerializeField]
    private Transform[] points;
    */

    [SerializeField]
    private List<Chest> chests;
    public void Start()
    {
        chests = new List<Chest>();

        Chest c1, c2, c3;
        c1 = new Chest();
        c2 = new Chest();
        c3 = new Chest();

        chests.Add(c1);
        chests.Add(c2);
        chests.Add(c3);
    }

    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Space))
            enteros.Add(Random.Range(0, 10));
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("La lista tiene " + enteros.Count + " elementos.");
            Debug.Log(enteros);
        }
        */
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (Chest c in chests)
                Debug.Log(c.open);
        }
    }
}
