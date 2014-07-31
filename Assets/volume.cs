﻿using System;
using System.Net.Mime;
using UnityEngine;
using System.Collections;

public class volume : MonoBehaviour
{

    private TextMesh tm;
    public AudioSource aud;

	// Use this for initialization

     void Awake()
    {
        var glazba = GameObject.Find(aud.ToString());
        tm = (TextMesh)GameObject.Find(aud.ToString()).GetComponent<TextMesh>();
         float cjeli;
         cjeli = glazba.audio.volume*10;
         cjeli = Convert.ToInt32(cjeli);
         tm.text = cjeli.ToString();


    }

    void Start () {
        
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseEnter()
    {
        renderer.material.color = Color.gray;

    }

    private void OnMouseDown()
    {
        if (gameObject.name == "arrow-right")
        {

           

            int a = int.Parse(tm.text);

            if (a < 10)
            {
                var glazba = GameObject.Find(aud.ToString());
                glazba.audio.volume += .1f;
                a = a + 1;

            }
            tm.text = a.ToString();
        }





            if (gameObject.name == "arrow-left")
            {
                
                
                var glazba = GameObject.Find(aud.ToString());
                glazba.audio.volume -= .1f;
               int a = int.Parse(tm.text);

                if (a == 10||a>0){
                  a = a - 1;    
                    }
                tm.text = a.ToString();
            }
        }
    


    void OnMouseExit()
    {

        renderer.material.color = Color.white;
    }

  
}
