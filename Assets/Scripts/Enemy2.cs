using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    [SerializeField]
    private Vector3[] dir;

    private MoveBehaviour _movebehaviour;
    void Awake()
    {
        _movebehaviour = GetComponent<MoveBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        _movebehaviour.move();
    }
}
