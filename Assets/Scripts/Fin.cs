using UnityEngine.SceneManagement;
using UnityEngine;

public class Fin : MonoBehaviour
{
   

   
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Finish")
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
           
        }
        
    }
    
}
