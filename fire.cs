using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fire : MonoBehaviour
{
    private float timer;
    Rigidbody2D rb;
    Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>0.2)
        {
            Destroy(gameObject);
        }
       // flip();
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
   
    {
        if (collision.gameObject.tag == "gate")
        {
            Destroy(collision.gameObject);
           
        }
        if (collision.gameObject.tag == "enemy")
        {
             Destroy(collision.gameObject);
            anim.SetFloat("Blend", 5);
        }

    }
    //private void flip()
    //{
    //    Vector3 localScale = transform.localScale;
    //    localScale.x *= -1;
    //    transform.localScale = localScale;
    //}
}
