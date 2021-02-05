using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 8.0f;
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

    }
}
