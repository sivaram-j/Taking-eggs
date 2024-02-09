using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class shoot : MonoBehaviour
    {

        public Transform firepoint;
     
        public GameObject fireprefab;
        public float shootspeed = 100f;
   
        // Start is called before the first frame update
        void Start()
        {
      
    }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(2))
            {
                Shoot();
            
            }
        }

    private void  Shoot()
    {
        GameObject bullet = Instantiate(fireprefab, firepoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.right * shootspeed, ForceMode2D.Impulse);
    }
       
    
    }
