using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float jumpForce = 10f;
    AudioSource jumpsound;
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public string CurrentColor;

    public Color colorBlue;
    public Color colorGreen;
    public Color colorRed;
    public Color colorYellow;


    void Start()
    {
        SetRandomColor();
        jumpsound = GetComponent<AudioSource>();

    }

    void Update()
    {
        if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            jumpsound.Play();
            rb.velocity = Vector2.up * jumpForce;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
       
        
        if (col.tag == "ChangeBlue")
        {
            CurrentColor = "Blue";
            sr.color = colorBlue;
            Destroy(col.gameObject);
            return;
        }
        if (col.tag == "ChangeGreen")
        {
            CurrentColor = "Green";
            sr.color = colorGreen;
            Destroy(col.gameObject);
            return;
        }
        if (col.tag == "ChangeYellow")
        {
            CurrentColor = "Yellow";
            sr.color = colorYellow;
            Destroy(col.gameObject);
            return;
        }
        if (col.tag == "ChangeRed")
        {
            CurrentColor = "Red";
            sr.color = colorRed;
            Destroy(col.gameObject);
            return;
        }
        if (col.tag != CurrentColor )
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
    void SetRandomColor()
    {
        int index = Random.Range(0, 4);
        switch (index)
        {
            case 0:
                CurrentColor = "Blue";
                sr.color = colorBlue;
                break;
            case 1:
                CurrentColor = "Green";
                sr.color = colorGreen;
                break;
            case 2:
                CurrentColor = "Red";
                sr.color = colorRed;
                break;
            case 3:
                CurrentColor = "Yellow";
                sr.color = colorYellow;
                break;
        }
    }
}
