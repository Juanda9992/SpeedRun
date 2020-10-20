using UnityEngine;

public class PlayerController : MonoBehaviour
{

    #region PublicStuff
    public float MoveSpeed;
    public float jumpForce;
    #endregion

    #region PrivateStuff
    private Rigidbody2D rb;
    private float xMove; 
    private float step;
    float minSpeed = -12;
    float maxSpeed = 15;
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

        Debug.Log(rb.velocity.x);
    }

    #region Methods
    #endregion
}
