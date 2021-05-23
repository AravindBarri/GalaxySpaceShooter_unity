using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;

    AudioSource bulletaudio;
    public AudioClip bulletclip;

    // Start is called before the first frame update
    private void Start()
    {
        bulletaudio = GameObject.Find("SoundManager").GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        //rb.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);
        rb.velocity = new Vector2(0, bulletForce);
        bulletaudio.clip = bulletclip;
        bulletaudio.Play();
    }
}