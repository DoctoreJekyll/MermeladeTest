using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    private Rigidbody2D rb2d;
    [SerializeField] private float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var inputsHorizontal = Input.GetAxisRaw("Horizontal");
        var inputsVertical = Input.GetAxisRaw("Vertical");

        var inputs = new Vector2(inputsHorizontal, inputsVertical).normalized;

        rb2d.velocity = inputs * speed;

    }
}
