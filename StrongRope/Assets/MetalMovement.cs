using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalMovement : MonoBehaviour
{


    float tmpSpeed;

    public bool sagBasladi;

    [SerializeField] float speed;


    [SerializeField] float solSpeed;


    public Rigidbody2D rigidbody2D;

    int sayac;

    float time;

    float time2;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        tmpSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(1*Time.deltaTime * speed, 0, 0);

        /*
        time2 += Time.deltaTime;
        if (time2 < 0.5f)
        {
            time2 += Time.deltaTime;
        }
        else
        {
            Debug.Log(time);
            time2 += Time.deltaTime;
            rigidbody2D.velocity = new Vector3(-50 * Time.deltaTime, 0, 0);
        }
        *
        *
        */


        transform.position += new Vector3(-solSpeed * Time.deltaTime, 0, 0);

        if (sagBasladi &&  speed>0)
        {
            transform.position += new Vector3(speed* Time.deltaTime, 0, 0);

            speed -= 0.1f;
          

        }       
        

        if (Input.GetKeyDown(KeyCode.A))
        {
            sagBasladi = true;


            speed = tmpSpeed;

            /*if (sayac < 3)
            {
                sayac++;
                

                Vector3 a = new Vector3(0.01f, 0, 0);
                rigidbody2D.velocity = a * speed;

                
            }
            */
            
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            sayac = 0;

        }






    }
}
