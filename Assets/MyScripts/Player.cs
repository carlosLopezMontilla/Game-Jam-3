using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    public float acceleration;

    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        _rb.velocity = new Vector3(x * speed, _rb.velocity.y, z * speed);

        if (z > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if(z < 0)
        {
            transform.eulerAngles = new Vector3(0, 180f, 0);
        }



    }
}
