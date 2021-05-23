using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyprefab;
    float time = 0f;

    PlayerMovement player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > 3.0f && player !=null)
        {
            float x = Random.Range(-6.0f, 7.0f);
            GameObject enemyRef = Instantiate(enemyprefab);
            enemyRef.transform.position = new Vector3(x, 9.95f, 0);
            time = 0f;
        }
        
    }
}
