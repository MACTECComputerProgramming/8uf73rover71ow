using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{[SerializeField] private float speed;
    
    private Rigidbody2D Body;

    private void Awake()
    {
        Body = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        Body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Body.velocity.y);



        if (Input.GetKey(KeyCode.Space))
            Body.velocity = new Vector2(Body.velocity.x, speed);

    }

}
