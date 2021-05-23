using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletDestroyer : MonoBehaviour
{
    AudioSource destroysound;
    public AudioClip DestroyClip;
    public AudioClip bulletclip;
    ScoreManager Scoreref;
    private void Start()
    {
        destroysound = GameObject.Find("SoundManager").GetComponent<AudioSource>();
        Scoreref = FindObjectOfType<ScoreManager>();
    }
    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            destroysound.clip = DestroyClip;
            destroysound.Play();
            Scoreref.IncrementScore();
        }
    }   
}
