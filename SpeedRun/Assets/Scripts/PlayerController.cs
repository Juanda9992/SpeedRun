using UnityEngine;

public class PlayerController : MonoBehaviour
{

    #region PublicStuff
    public float MoveSpeed;
    #endregion

    #region PrivateStuff
    private Rigidbody2D rb;
    private float xMove; 
    private float step;
    float minSpeed = -8;
    float maxSpeed = 8;
    #endregion

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        xMove = Input.GetAxis("Horizontal");

        if(xMove > 0)
        {
            rb.AddForce(Vector2.right * MoveSpeed);
        }

        if(xMove < 0)
        {
            rb.AddForce(Vector2.right * MoveSpeed * -1);
        }

        if(rb.velocity.x < minSpeed)
        {
            rb.AddForce(Vector2.right * MoveSpeed);
        }

        if(rb.velocity.x > maxSpeed)
        {
            rb.AddForce(Vector2.right * MoveSpeed * -1);
        }

    }

    #region Methods
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Pad"))
        {
            rb.AddForce(Vector2.up * 15, ForceMode2D.Impulse);
        }    
    }
    private void OnTriggerStay2D(Collider2D other) 
    {
        if(other.CompareTag("Dash"))
        {
            if(Input.GetMouseButton(0))
            {
                rb.velocity = other.transform.up * 1000 * Time.deltaTime;
            }
        }    
    }
    #endregion
}
