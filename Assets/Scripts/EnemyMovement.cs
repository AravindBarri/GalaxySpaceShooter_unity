using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody2D enemyRB;

    AudioSource destroysound;
    public AudioClip DestroyClip;
    public AudioClip bulletclip;

    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();
        destroysound = GameObject.Find("SoundManager").GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        enemyRB.velocity = new Vector2(0, -2);
    }
    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            destroysound.clip = DestroyClip;
            destroysound.Play();
            Destroy(collision.gameObject);
            Destroy(gameObject);
            SceneManager.LoadScene(2);
        }
    }

}
