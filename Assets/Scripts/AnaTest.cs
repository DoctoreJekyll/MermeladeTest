using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnaTest : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2;
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }

    private void movement()
    {
        
        var input = Input.GetAxisRaw("Horizontal");
        var input2 = Input.GetAxisRaw("Vertical");
        rb2.velocity = new Vector2(input * speed, input2 * speed);
    }
}
