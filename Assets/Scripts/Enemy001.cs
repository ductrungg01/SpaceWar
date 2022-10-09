using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy001 : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public GameObject bullet;
    public float spawnTime = 3.0f;
    float m_spawnTime;

    // Start is called before the first frame update
    void Start()
    {
        m_spawnTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        m_spawnTime -= Time.deltaTime;

        if (m_spawnTime <= 0)
        {
            m_spawnTime = spawnTime;
            spawnBullet();
        }
    }

    void spawnBullet()
    {
        Vector2 bulletPosition = new Vector2(this.transform.position.x, this.transform.position.y - 0.65f);

        if (bullet)
        {
            Instantiate(bullet, bulletPosition, Quaternion.identity);
        }
    }

    private void FixedUpdate()
    {
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Va cham ENEMY - PLAYER");
        }
    }
}
