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
    [SerializeField] private string levelToLoad;
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
        if(other.CompareTag("Respawn"))
        {
            SceneLoader.LoadScene(levelToLoad);
        }
    }
    private void OnTriggerStay2D(Collider2D other) 
    {
        if(other.CompareTag("Dash"))
        {
            if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                rb.velocity = other.transform.up * 700 * Time.deltaTime;
            }
        }    
    }
    #endregion
}
