using UnityEngine.SceneManagement;
using UnityEngine;

public class YesButton : MonoBehaviour
{
   void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
