using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private Vector2 origin;
    public Rigidbody2D rb;

    void Start(){
        origin = this.transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Fuckin' right doggie!!!");

        if(other.gameObject.CompareTag("Finish")){
            GetComponent<Rigidbody2D>().position = Vector2.zero;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            transform.position = origin;
        }
    }
}
