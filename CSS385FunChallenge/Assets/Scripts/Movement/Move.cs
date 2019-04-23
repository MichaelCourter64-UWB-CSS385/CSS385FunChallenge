using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public float forwardForce = 10f;
    public float upwardForce = 30f;
    public float rayPercent = 1f;
    public float xVelocityLimit;

    CircleCollider2D collider;

    bool isJumping = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<CircleCollider2D>();
    }



    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.x <= xVelocityLimit)
        {
            rb.AddForce(transform.right * forwardForce * Time.deltaTime);
        }

        if(Input.GetKey("space"))
        {
            Vector2 rayOrigin = new Vector2(transform.position.x, transform.position.y - collider.radius - 0.05f);

            RaycastHit2D rayResult = Physics2D.Raycast(rayOrigin, new Vector2(0, -1), collider.radius * rayPercent);

            //Debug.Log(rayResult.transform);

            if(rayResult.transform != null)
            {
                isJumping = true;
            }
            
        }
//        Debug.Log(GetComponent<Rigidbody2D>().velocity);
    }

    void FixedUpdate()
    {
        if (isJumping)
        {
            //Debug.Log("Jumped: " + transform.up * upwardForce);
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(transform.up * upwardForce * Time.deltaTime);
            
//            Debug.Log(GetComponent<Rigidbody2D>().velocity);

            isJumping = false;
        }
    }
}
