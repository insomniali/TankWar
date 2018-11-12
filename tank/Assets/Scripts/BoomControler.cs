using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BoomControler : MonoBehaviour {

    public Vector3 playertransform;
    public int BDirection;
    public float movespeed;//射速
    public int flag;
    public int shotdirection;
    DateTime nowTime;
    public DateTime shotTime;
    TimeSpan timespan;

    // Use this for initialization
    void Start () {
		
	}
	


    void Awake()
    {
        this.transform.position = playertransform;
    }

    void Update()
    {
        nowTime = System.DateTime.Now;
        timespan = nowTime - shotTime;
        playertransform = GameObject.Find("Player").GetComponent<move>().tank_position;
        BDirection = GameObject.Find("Player").GetComponent<Player>().Direction;


        if (flag == 1)
        {
            if (timespan.Seconds > 5)
            {
                this.transform.position = playertransform;
                flag = 0;
            }
            else
            {
                if (shotdirection == 0)
                {
                    moveUp();
                }
                if (shotdirection == 1)
                {
                    moveRight();
                }
                if (shotdirection == 2)
                {
                    moveLeft();
                }
                if (shotdirection == 3)
                {
                    moveDown();
                }

            }
        }
        else if (flag == 0)
        {
            this.transform.position = playertransform;
            if (Input.GetKeyDown(KeyCode.L))
            {
                flag = 1;
                shotTime = System.DateTime.Now;
                shotdirection = BDirection;
                if (BDirection == 0)
                {
                    moveUp();

                }
                if (BDirection == 1)
                {
                    moveRight();
                }
                if (BDirection == 3)
                {
                    moveDown();
                }
                if (BDirection == 2)
                {
                    moveLeft();
                }
            }

        }
    }

    void moveRight()
    {
        this.transform.position += new Vector3(movespeed, 0, 0);
        this.transform.eulerAngles = new Vector3(0, 0, -90);
    }
    void moveUp()
    {
        this.transform.position += new Vector3(0, movespeed, 0);
        this.transform.eulerAngles = new Vector3(0, 0, 0);
    }
    void moveDown()
    {
        this.transform.position += new Vector3(0, -movespeed, 0);
        this.transform.eulerAngles = new Vector3(0, 0, 180);
    }
    void moveLeft()
    {
        this.transform.position += new Vector3(-movespeed, 0, 0);
        this.transform.eulerAngles = new Vector3(0, 0, 90);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Box" || collision.gameObject.tag == "Stone" || collision.gameObject.tag == "enemy")
        {
            flag = 0;
        }
    }
}


