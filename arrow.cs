using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
     float timer;
   
   // private GameObject bird;
    private Rigidbody2D rb;
    public float force;
   // public GameObject gameover;
   // public GameObject replay;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
        //bird = GameObject.FindGameObjectWithTag("bird");
        //Vector3 direction = bird.transform.position - transform.position;
        //rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
       
    }

    // Update is called once per frame
    void Update()
    {
        
      
        timer += Time.deltaTime;
        if (timer > 0.5)
        {
            Destroy(gameObject);
        }
       // flip();
    } 
    
    //private void OnCollisionEnter2D(Collision2D collision)
    
        
    
    //{
    //    if(collision.gameObject.tag=="bird")
    //    {
    //        //Destroy(collision.gameObject);
    //        bird.animater.SetFloat("Blend", 2);
    //        gameover.SetActive(true);
    //        replay.SetActive(true);
    //        bird.check = false;


    //    }
    //}
}
