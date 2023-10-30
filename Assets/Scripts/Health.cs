using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class Health : MonoBehaviour
{
    public Hud hud;
    public float timer;
    public float originalTimer = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        timer = originalTimer;
        hud = GameObject.FindObjectOfType<Hud>();
    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;
        if (timer > 0)
        {
            
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("hit something");
        if (other.gameObject.CompareTag("Spikes"))
        {
            print("hit a spike");
            hud.health = hud.health - 1;
        }
        
        if (other.gameObject.CompareTag("Heart"))
        {
            hud.health = hud.health + 1;
            other.gameObject.SetActive(false);
        }
    }
}
