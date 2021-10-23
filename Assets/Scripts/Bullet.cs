using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public float speed = 1.0f;
    Rigidbody2D rb;
    private Vector2 screenBounds;

    //public GameObject target;
    //public Transform targetTrans;

    Enemy target;
    Vector2 moveDirection;


    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        //target = GameObject.Find("Enemy");
        //targetTrans.position = target.transform.position;
        target = GameObject.FindObjectOfType<Enemy>();
        moveDirection = (target.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        //rb.velocity = new Vector2(0, speed);
        Destroy(gameObject, 4f);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > screenBounds.y * 0.85 && transform.position.y < screenBounds.y * -0.85)
        {
            Destroy(this.gameObject);
        }
    }
  

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            ScoreCount.scoreAmount += 1;

            Destroy(other.gameObject);
            SoundManager.PlaySound("Explosion");

            Destroy(this.gameObject);
        }

        if (ScoreCount.scoreAmount == 11)
        {
            SceneManager.LoadScene("WinScene");

            //SceneManager.LoadScene(Bullet);
        }
    }
}
