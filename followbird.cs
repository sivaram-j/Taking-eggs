using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followbird : MonoBehaviour
{
    public Transform Bird;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Bird.position + offset;
    }
}
