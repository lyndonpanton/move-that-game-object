using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 newScale = transform.localScale;

        newScale.x *= 5;
        newScale.y *= 5;

        transform.localScale = newScale;


        Rigidbody2D rb2d= GetComponent<Rigidbody2D>();

        rb2d.AddForce(
            new Vector2(-5, 2),
            ForceMode2D.Impulse
        );
    }
}
