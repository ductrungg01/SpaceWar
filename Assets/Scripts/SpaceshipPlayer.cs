using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipPlayer : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    float xDirection, yDirection;

    public GameObject bullet;
    public float bulletDowntime = 0.2f;
    float m_time;

    // Start is called before the first frame update
    void Start()
    {
        m_time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        m_time -= Time.deltaTime;

        if (Input.GetKey(KeyCode.Space) && m_time <= 0)
        {
            if (bullet)
            {
                spawnBullet();
            }

            m_time = bulletDowntime;
        }
    }

    void spawnBullet()
    {
        Vector2 bulletPosition = new Vector2(this.transform.position.x, this.transform.position.y + 0.65f);

        if (bullet)
        {
            Instantiate(bullet, bulletPosition, Quaternion.identity);
        }
    }

    private void FixedUpdate()
    {
        xDirection = Input.GetAxisRaw("Horizontal");
        yDirection = Input.GetAxisRaw("Vertical");

        float xMoveStep = moveSpeed * Time.deltaTime * xDirection;
        float yMoveStep = moveSpeed * Time.deltaTime * yDirection;

        if ((transform.position.x < -5 && xDirection < 0) || (transform.position.x > 5 && xDirection > 0))
        {
            return;
        }
        if ((transform.position.y < -8.4 && yDirection < 0) || (transform.position.y > 8.4 && yDirection > 0))
        {
            return;
        }

        transform.position += new Vector3(xMoveStep, yMoveStep, 0);
    }
}
