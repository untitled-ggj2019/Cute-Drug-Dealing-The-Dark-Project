﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Doused : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb2d;
    private BoxCollider2D boxCollide;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        boxCollide = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            anim.SetTrigger("Doused");
        }  
    }
}