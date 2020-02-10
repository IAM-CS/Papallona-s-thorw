using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot: MonoBehaviour
{
    private MoveBehaviour _movebehaviour;
    private void Awake()
    {
        _movebehaviour = GetComponent<MoveBehaviour>();
    }

    public void FixedUpdate()
    {
        _movebehaviour.move();
    }
}
