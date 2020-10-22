using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    #region PublicStuff
    #endregion

    #region PrivateStuff
    #endregion

    public static void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    #region Methods
    #endregion
}
