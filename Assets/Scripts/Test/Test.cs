using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private float speed;


    private int number1;
    private float number2;
    private bool tinaMeAma;
    private string test;
    private char c;
    
    private string namePj;
    private string pjClass;
    private char pjSex;
    
    
    private Rigidbody2D rb2d;
    private SpriteRenderer sprite;


    [SerializeField] private int test1;
    public int test2;

    private void Awake()
    {
        number1 = 1;
        number2 = 2.56565f;
        tinaMeAma = false;
        test = "Tina i love u";
        c = 't';

        namePj = "Valentina";
        pjClass = "Support impostor";
        pjSex = 'F';
    }

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputsHorizontal = Input.GetAxisRaw("Horizontal");
        
        var inputsVertical = Input.GetAxisRaw("Vertical");

        var inputs = new Vector2(inputsHorizontal, inputsVertical).normalized;

        rb2d.velocity = inputs * speed;

    }

    private void MovementPlayer()
    {
        TestGetAxis("Horizontal");
    }

    private void TestGetAxis(string name)
    {
        name = "test";
    }
}
