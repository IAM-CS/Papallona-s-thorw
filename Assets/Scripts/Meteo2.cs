using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteo2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
