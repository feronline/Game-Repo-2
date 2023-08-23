using UnityEngine;
using UnityEngine.SceneManagement;

public class FallTrigger : MonoBehaviour
{
    public Transform cam;
    void Update()
    {
        if (cam.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, cam.position.y-7f, transform.position.z);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
