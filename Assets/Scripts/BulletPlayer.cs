using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlayer : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    GameController m_gc;

    // Start is called before the first frame update
    void Start()
    {
        m_gc = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        transform.position += Vector3.up * moveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            m_gc.setGameOverState(true);
        } else if (collision.CompareTag("DeathZone"))
        {
            Destroy(gameObject);
        }
    }
}
