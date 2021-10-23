using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverCondition : MonoBehaviour
{
    public int index;
    public string EndPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            
            LifeCount.liveAmount -= 1;
            SoundManager.PlaySound("CoinCollectAudio");
        }

        

        if (LifeCount.liveAmount == 0)
        {
            StartCoroutine(Timedelay());
            SceneManager.LoadScene(index);
            
            SceneManager.LoadScene(EndPoint);
        }
    }

    IEnumerator Timedelay()
    {
        yield return new WaitForSeconds(3f);
    }
}
