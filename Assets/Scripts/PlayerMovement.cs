using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float playerspeed;
    public Player localplayer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(horizontal, vertical) * playerspeed;
        rb.position = new Vector2(Mathf.Clamp(rb.position.x, localplayer.xMin, localplayer.xMax), Mathf.Clamp(rb.position.y, localplayer.yMin, localplayer.yMax));
        // Update is called once per frame

    }
    [System.Serializable]
    public class Player
    {
        public float xMin, xMax, yMin, yMax;
    }
}