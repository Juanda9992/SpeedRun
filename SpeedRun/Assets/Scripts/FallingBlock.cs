using UnityEngine;

public class FallingBlock : MonoBehaviour
{

    #region PublicStuff

    #endregion

    #region PrivateStuff
    Rigidbody2D rb;
    #endregion

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.transform.CompareTag("Player"))
        {
            Invoke("Fall", 0.2f);
        }    
    }
    private void Fall()
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
        rb.gravityScale = 2;
    }

    #region Methods
    #endregion
}
