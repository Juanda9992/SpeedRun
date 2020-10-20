using UnityEngine;

public class DashOrb : MonoBehaviour
{

    #region PublicStuff
    public BoxCollider2D dashZone;
    #endregion

    #region PrivateStuff
    PolygonCollider2D pollygon;
    #endregion
    private void Start() 
    {
        dashZone.enabled = false;    
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Player");
            if(Input.GetMouseButton(0))
            {
                dashZone.enabled = true;
            }
        }    
    }

    #region Methods
    #endregion
}
