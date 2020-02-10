using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject shotPrefab;
    public GameObject shotPoint;
    private MoveBehaviour _movebehaviour;
    void Start()
    {
        _movebehaviour = GetComponent<MoveBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            _movebehaviour.move(new Vector2(1, 0));
        }

        if (Input.GetKey(KeyCode.A))
        {
            _movebehaviour.move(new Vector2(-1, 0));
        }

        if (Input.GetKey(KeyCode.W))
        {
            _movebehaviour.move(new Vector2(0, 1));
        }

        if (Input.GetKey(KeyCode.S))
        {
            _movebehaviour.move(new Vector2(0, -1));
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(shotPrefab, shotPoint.transform.position,
                Quaternion.identity);
        }
    }
}
