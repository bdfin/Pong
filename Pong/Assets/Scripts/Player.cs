using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed = 8.0f;
    public float topMovementLimit = 8.3f;
    public float bottomMovementLimit = -8.3f;
    public Vector2 startingPosition = new Vector2(-13f, 0.0f);

    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = (Vector3)startingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        CheckUserInput();
    }

    void CheckUserInput()
    {
        if (Input.GetKey(KeyCode.UpArrow)) 
        {
            if (transform.localPosition.y > topMovementLimit) 
            {
                transform.localPosition = new Vector3(transform.localPosition.x, topMovementLimit, transform.localPosition.z);
            }
            else 
            {
                transform.localPosition += Vector3.up * movementSpeed * Time.deltaTime;
            }
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            if (transform.localPosition.y < bottomMovementLimit)
            {
                transform.localPosition = new Vector3(transform.localPosition.x, bottomMovementLimit, transform.localPosition.z);
            }
            else
            {
                transform.localPosition += Vector3.down * movementSpeed * Time.deltaTime;
            }
        }
    }
}
