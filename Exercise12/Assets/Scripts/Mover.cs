using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb2d= GetComponent<Rigidbody2D>();

        rb2d.AddForce(
            new Vector2(0, 5),
            ForceMode2D.Impulse
        );
    }
}
