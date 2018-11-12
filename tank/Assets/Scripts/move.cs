using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Collections;

public class move : MonoBehaviour {
    public float movespeed;
    DateTime currentTime;
    DateTime kTime;
    TimeSpan span;
    public Vector3 tank_position;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        tank_position = this.transform.position;
        float x = tank_position.x;
        float y = tank_position.y;
        currentTime = System.DateTime.Now;
        span = currentTime - kTime;

        if (this.gameObject.tag == "Player")
        {

            if (span.Seconds > 10)
            {
                GameObject.Find("Player").GetComponent<move>().movespeed = 0.1f;
            }

            if (Input.GetKey(KeyCode.D))
            {
                if (x <= -93.67)
                {
                    moveRight();
                    this.transform.eulerAngles = new Vector3(0, 0, -90);
                }
                tank_position = this.transform.position;
                x = tank_position.x;
            }

            if (Input.GetKey(KeyCode.W))
            {
                if (y <= -53.45)
                {
                    moveUp();
                    this.transform.eulerAngles = new Vector3(0, 0, 0);
                }
                tank_position = this.transform.position;
                y = tank_position.y;
            }

            if (Input.GetKey(KeyCode.S))
            {
                if (y >= -99)
                {
                    moveDown();
                    this.transform.eulerAngles = new Vector3(0, 0, 180);
                }
                tank_position = this.transform.position;
                y = tank_position.y;

            }

            if (Input.GetKey(KeyCode.A))
            {

                if (x >= -139.1)
                {
                    moveLeft();
                    this.transform.eulerAngles = new Vector3(0, 0, 90);
                }
                tank_position = this.transform.position;
                x = tank_position.x;
            }

            if (Input.GetKeyDown(KeyCode.K))
            {
                kTime = System.DateTime.Now;
                Debug.Log("k second   " + System.DateTime.Now.Second);
                speedUp();
            }
        }
    }

    void moveRight()
    {
        this.transform.position += new Vector3(movespeed, 0, 0);
        GameObject.Find("Player").GetComponent<Player>().Direction = 1;
    }
    void moveUp()
    {
        this.transform.position += new Vector3(0, movespeed, 0);
        GameObject.Find("Player").GetComponent<Player>().Direction = 0;
    }
    void moveDown()
    {
        this.transform.position += new Vector3(0, -movespeed, 0);
        GameObject.Find("Player").GetComponent<Player>().Direction = 3;
    }
    void moveLeft()
    {
        this.transform.position += new Vector3(-movespeed, 0, 0);
        GameObject.Find("Player").GetComponent<Player>().Direction = 2;
    }
    void speedUp()
    {
        GameObject.Find("Player").GetComponent<move>().movespeed += 0.1f;
    }
    void speedDown()
    {
        GameObject.Find("Player").GetComponent<move>().movespeed -= 0.05f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet" && this.gameObject.tag == "enemy")
        {
            GameObject.Find("enemy").GetComponent<Player>().Life -= 1;
            Debug.Log(GameObject.Find("enemy").GetComponent<Player>().Life);
            if (this.gameObject.tag == "enemy" && GameObject.Find("enemy").GetComponent<Player>().Life <= 0)
            {
                Destroy(this.gameObject);
            }
        }



        if (collision.gameObject.tag != "Drop"&& collision.gameObject.tag != "Bullet")
           {           
             if (GameObject.Find("Player").GetComponent<Player>().Direction == 0)
            {               
                this.transform.position -= new Vector3(0, 0.2f, 0);
            }
            else if (GameObject.Find("Player").GetComponent<Player>().Direction == 3)
            {
                this.transform.position -= new Vector3(0, -0.2f, 0);
            }
            else if (GameObject.Find("Player").GetComponent<Player>().Direction == 1)
            {
                this.transform.position -= new Vector3(0.2f, 0, 0);
            }
            else if (GameObject.Find("Player").GetComponent<Player>().Direction == 2)
            {
                this.transform.position -= new Vector3(-0.2f, 0, 0);
            }
         }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Drop" && collision.gameObject.tag != "Bullet")
          {
            if (GameObject.Find("Player").GetComponent<Player>().Direction == 0)
            {
                this.transform.position -= new Vector3(0, 0.4f, 0);
            }
            else if (GameObject.Find("Player").GetComponent<Player>().Direction == 3)
            {
                this.transform.position -= new Vector3(0, -0.4f, 0);
            }
            else if (GameObject.Find("Player").GetComponent<Player>().Direction == 1)
            {
                this.transform.position -= new Vector3(0.4f, 0, 0);
            }
            else if (GameObject.Find("Player").GetComponent<Player>().Direction == 2)
            {
                this.transform.position -= new Vector3(-0.4f, 0, 0);
            }
       }
    }
}
