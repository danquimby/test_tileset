using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterMove : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField]
    private float speedMultiplier;
    void Awake()
    {
        if (rb2d == null)
            rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        //Debug.Log("Input.GetAxis(\"Horizontal\")  " + Input.GetAxis("Horizontal"));
        //if (Input.GetAxis("Horizontal") != 0)
        //{

        //}
        //else if (Input.GetAxis("Vertical") != 0)
        //{

        //}
        rb2d.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * speedMultiplier, 0.8f),
                                            Mathf.Lerp(0, Input.GetAxis("Vertical") * speedMultiplier, 0.8f));
    }
}
