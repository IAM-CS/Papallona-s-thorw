using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private MoveBehaviour _movebehaviour;
    void Awake()
    {
        _movebehaviour = GetComponent<MoveBehaviour>();
    }


    void Update()
    {
        _movebehaviour.move();
    }
}
