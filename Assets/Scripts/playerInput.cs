using UnityEngine;
using UnityEngine.InputSystem;

public class playerInput : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 10;
    public float jumpSpeed = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float moveHoriz = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Horizontal");
        float xSpeed = moveHoriz * speed;
        rb.linearVelocityX = xSpeed;
        if (Input.GetKeyDown("space"))
        {
            Vector2 jump = new Vector2(0.0f, moveVert * jumpSpeed);
            rb.AddForce(jump);
        }

        //transform.Translate(new Vector3(moveHoriz, moveVert, 0) * speed * Time.deltaTime);
        //Vector2 moveVector = new Vector2(moveHoriz, 0.0f);
        //if (Input.GetKeyDown("a"))
        //{
        //    rb.AddForce(moveVector*speed);
        //    print("a pressed");
        //}
    }
}
