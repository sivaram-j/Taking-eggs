using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    //public GameObject homescreen;
   
    public GameObject fireprefab;
    public Transform firepoint;
    private float timer;
    public float shootspeed = 100f;
    public GameObject pointA;
    public GameObject pointB;
    Rigidbody2D rb;
    private Animator anim;
    private Transform currentpoint;
    public float speed;
   // public float distance;
    bool check  ;
    // Start is called before the first frame update
    void Start()
    {
       
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        currentpoint = pointB.transform;
        // anim.SetBool("New Bool", true);
        //homescreen.SetActive(true);
      


    }
    //void playmode()
    //{
    //   bird. homescreen.SetActive(false);
    //  check=true;
    //}
    // Update is called once per frame
    private void Update()
    {



        //timer += Time.deltaTime;
        //if (timer > 1)
        //{
        //timer = 0;
        //Shoot();



        //}



        //if (true)
        //{

            Vector2 point = currentpoint.position - transform.position;
            if (currentpoint == pointB.transform)
            {
                rb.velocity = new Vector2(speed, 0);
                anim.SetFloat("Blend", 3);
            }
            else
            {
                rb.velocity = new Vector2(-speed, 0);
                anim.SetFloat("Blend", 3);

            }
            if (Vector2.Distance(transform.position, currentpoint.position) < 0.5f && currentpoint == pointB.transform)
            {
                flip();
                Shoot();

                currentpoint = pointA.transform;

            }
            if (Vector2.Distance(transform.position, currentpoint.position) < 0.5f && currentpoint == pointA.transform)
            {
                flip();

                Shoot();

                currentpoint = pointB.transform;


            }
        //}
        
    }
    private void flip()
    {
        bool playermove = Mathf.Abs(rb.velocity.x) > 0;
        if (playermove)
        {
            if (rb.velocity.x < 0)
                transform.localRotation = Quaternion.Euler(0, 0, 0);
            else
                transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(pointA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointB.transform.position, 0.5f);
        Gizmos.DrawLine(pointA.transform.position, pointB.transform.position);

    }
  private void Shoot()
   {

        
        GameObject bullet= Instantiate(fireprefab, firepoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
       rb.AddForce(firepoint.right * shootspeed, ForceMode2D.Impulse);
        
    }
   

        

    }


