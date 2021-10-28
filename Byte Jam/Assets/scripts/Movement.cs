
using UnityEngine;

public class Movement : MonoBehaviour
{[SerializeField] private float speed;
    
    private Rigidbody2D Body;
    private bool isJumping;
    public float Space;
    
    private void Awake()
    {
        Body = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        Body.velocity = new Vector2(Input.GetAxis("Horizontal") *speed , Body.velocity.y);



        if (Input.GetKey(KeyCode.Space))
            Body.velocity = new Vector2(Body.velocity.x, speed);

        speed = 20;


        if ((Input.GetKey(KeyCode.Space)) && !isJumping ) 
        {
            Body.AddForce(new Vector2(Body.velocity.x, Space));
            isJumping = true;
        
        }
    
    }

}
