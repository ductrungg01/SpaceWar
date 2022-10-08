using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipPlayer : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    float xDirection, yDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxisRaw("Horizontal");
        yDirection = Input.GetAxisRaw("Vertical");

        if (xDirection != 0) Debug.Log(xDirection);
        if (yDirection != 0) Debug.Log(yDirection);

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
