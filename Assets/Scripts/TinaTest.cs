using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TinaTest : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] private SpriteRenderer sr2d;
    [SerializeField] private float vl;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    
    void Movement()
    {
        float inputKb = Input.GetAxisRaw("Horizontal");
        float inputKbVt = Input.GetAxisRaw("Vertical");
        




        rb2d.velocity = new Vector2(inputKb * vl, inputKbVt * vl);
        

    }
}
