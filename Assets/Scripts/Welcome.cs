using UnityEngine.SceneManagement;
using UnityEngine;

public class Welcome : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Exit()
    {

        Application.Quit();
    }
}