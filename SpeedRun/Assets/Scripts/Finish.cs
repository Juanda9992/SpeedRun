using UnityEngine;

public class Finish : MonoBehaviour
{

    #region PublicStuff
    #endregion

    #region PrivateStuff
    [SerializeField] public string levelToLoad;
    #endregion
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            SceneLoader.LoadScene(levelToLoad);
        }
    }

    #region Methods
    #endregion
}
