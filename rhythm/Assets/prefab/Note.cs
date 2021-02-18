using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public Rigidbody2D rb;

    public float moveSpeed = 3f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.localPosition -= Vector3.up * moveSpeed * Time.deltaTime;

        //transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y * moveSpeed * Time.deltaTime, transform.localPosition.z);

        if (transform.localPosition.y <= -10f)
        {
            if(gameObject != null)
                Destroy(gameObject);
        }
    }
}
