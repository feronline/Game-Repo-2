using UnityEngine.SceneManagement;
using UnityEngine;

public class Back2Menu : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
