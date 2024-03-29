﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activator : MonoBehaviour
{
    SpriteRenderer sr;
    public KeyCode key;
    bool active = false;
    GameObject note;
    Color old;

    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        old = sr.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            StartCoroutine(Pressed());
        }

        if (Input.GetKeyDown(key) && active)
        {
            Destroy(note);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        active = true;
        if (col.gameObject.tag == "Note")
            //Destroy(col.gameObject);
            note = col.gameObject;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        active = false;
    }

    IEnumerator Pressed()
    {
        sr.color = new Color(10, 10, 10);
        yield return new WaitForSeconds(0.1f);
        sr.color = old;
    }

}
