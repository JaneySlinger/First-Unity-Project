using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        Rigidbody2D r = GetComponent<Rigidbody2D>() as Rigidbody2D;

        r.velocity = new Vector2(horizontalMovement * speed, verticalMovement * speed);

    }
}
