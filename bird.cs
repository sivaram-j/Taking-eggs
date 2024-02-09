using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bird : MonoBehaviour
{
 
    public static   Animator animater;
    public GameObject winner;
    public Text scoretext;
        int score;
        public float velocity = 5;
        public    GameObject homescreen;
        public   GameObject gameover;
        public  GameObject replay;
 
        public float speed = 5f;
       Rigidbody2D rb;
  public static  bool check;
        

      

        

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        animater = GetComponent<Animator>();
        homescreen.SetActive(true);
        gameover.SetActive(false);
       replay.SetActive(false);
        winner.SetActive(false);
    }

        // Update is called once per frame
        void Update()
        {
        keymove();
        flip();
           if (check)
            {

                var hor = Input.GetAxis("Horizontal");
                var ver = Input.GetAxis("Vertical");
                transform.position += new Vector3(hor, ver, 0) * speed * Time.deltaTime;
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    rb.velocity = Vector2.up * velocity;
                  animater.SetFloat("Blend",3);
                }

            }
        }
        public void playmode()
        {
          homescreen.SetActive(false);
            check = true;
        }
    
        private void OnCollisionEnter2D(Collision2D collision)
        {

        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "egg")
            {
                Destroy(collision.gameObject);
                score++;
                scoretext.text = score.ToString();
            }
            if (collision.gameObject.tag == "spike")
            {
               // Destroy(collision.gameObject);
            animater.SetFloat("Blend", 2);
            check = false;
            gameover.SetActive(true);
                replay.SetActive(true);
               

            }
        if (collision.gameObject.tag == "arrow")
        {
            // Destroy(collision.gameObject);
            animater.SetFloat("Blend", 2);
            check = false;
            gameover.SetActive(true);
            replay.SetActive(true);


        }
        if (score == 10)
        {
            winner.SetActive(true);
            check = false;

        }
    }
    public void restart()
    {
        replay.SetActive(true);

        SceneManager.LoadScene("SampleScene");
        check = false;
    }
    void flip()
    {
        bool playermove = Mathf.Abs(rb.velocity.x) > 0;
        if (playermove)
        {
            if (rb.velocity.x < 0)
                transform.localRotation = Quaternion.Euler(0, 180, 0);
            else
                transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }
    public void keymove()
    {
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            animater.SetFloat("Blend", 3);
            rb.velocity = Vector2.right * 2;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animater.SetFloat("Blend", 3);
        }
       
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            animater.SetFloat("Blend", 3);
            rb.velocity = Vector2.left * 2;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animater.SetFloat("Blend", 3);
        }


    }
    void Score()
    {

        scoretext.text = score.ToString();
    }

}
