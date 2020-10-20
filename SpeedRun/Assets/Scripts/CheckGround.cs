using UnityEngine;

public class CheckGround : MonoBehaviour
{

    #region PublicStuff
    public float jumpForce;
    public LayerMask groundLayer;
    public Transform groundDetection;
    public float circleRadius;
    #endregion

    #region PrivateStuff
    Rigidbody2D rb;
    bool canJump;
    #endregion

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space)&& canJump)
        {
            Jump();
        }    
    }
    void FixedUpdate()
    {
        canJump = Physics2D.OverlapCircle(groundDetection.position, circleRadius,groundLayer);
    }

    public void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce,ForceMode2D.Impulse);
    }

    #region Methods
    #endregion
}
