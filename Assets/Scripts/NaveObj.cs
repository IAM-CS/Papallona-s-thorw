using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveObj : MonoBehaviour
{
    private float _alfa;
    public float speed = 10.0F;
    public float speedrotation = 100.0F;
    private MoveBehaviour _movebehaviour;
    //public Transform posz;
    void Start()
    {
        _movebehaviour = GetComponent<MoveBehaviour>();
    }


    void FixedUpdate()
    {
        /*
        Vector3 posmouse = Input.mousePosition;
        posmouse.z = 10;
        Vector3 p = Camera.main.ScreenToWorldPoint(posmouse);
        _alfa = Mathf.Atan2(p.y - transform.position.y, p.x - transform.position.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(_alfa, Vector3.forward);
        */
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * speedrotation;
        if(translation == 10)
        {
            _movebehaviour.move(transform.up);
        }
        if(translation == -10)
        {
            _movebehaviour.move(transform.up * -1);
        }
        
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Rotate(0, 0, rotation);
        

    }
}
