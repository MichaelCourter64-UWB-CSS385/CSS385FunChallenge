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

    CircleCollider2D collider;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<CircleCollider2D>();
    }



    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.right* forwardForce * Time.deltaTime);
        if(Input.GetKey("space"))
        {
            Vector2 rayOrigin = new Vector2(transform.position.x, transform.position.y - collider.radius - 0.05f);

            RaycastHit2D rayResult = Physics2D.Raycast(rayOrigin, new Vector2(0, -1), collider.radius * rayPercent);

            Debug.Log(rayResult.transform);

            if(rayResult.transform != null)
            {
                Debug.Log("Jumped: " + transform.up * upwardForce * Time.deltaTime);
                rb.AddForce(transform.up * upwardForce * Time.deltaTime);
            }
            
        }
    }
}
