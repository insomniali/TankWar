using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaremaMove : MonoBehaviour
{

    public Transform playertransform;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movewithplayer();
    }

    void Movewithplayer()
    {

        if (playertransform.position.x > -106.0398) {
            if (playertransform.position.y < -89.61001)
            {
                this.transform.position = new Vector3((float)-106.0398, (float)-89.61001, -25);
            }
            else if (playertransform.position.y > -62.91042)
            {
                this.transform.position = new Vector3((float)-106.0398, (float)-62.91042, -25);
            }
            else
            {
                this.transform.position = new Vector3((float)-106.0398, playertransform.position.y, -25);
            }
        }
        else if (playertransform.position.x < -126.3395) {
            if (playertransform.position.y < -89.61001)
            {
                this.transform.position = new Vector3((float)-126.3395, (float)-89.61001, -25);
            }
            else if (playertransform.position.y > -62.91042)
            {
                this.transform.position = new Vector3((float)-126.3395, (float)-62.91042, -25);
            }
            else
            {
                this.transform.position = new Vector3((float)-126.3395, playertransform.position.y, -25);
            }
        }
        else if(playertransform.position.y < -89.61001)
        {
            if(playertransform.position.x > -106.0398)
            {
                this.transform.position = new Vector3((float)-106.0398, (float)-89.61001, -25);
            }
            else if(playertransform.position.x < -126.3395)
            {
                this.transform.position = new Vector3((float)-126.3395, (float)-89.61001, -25);
            }
            else
            {
                this.transform.position = new Vector3(playertransform.position.x, (float)-89.61001, -25);
            }
        }
        else if (playertransform.position.y > -62.91042)
        {
            if (playertransform.position.x > -106.0398)
            {
                this.transform.position = new Vector3((float)-106.0398, (float)-62.91042, -25);
            }
            else if (playertransform.position.x < -126.3395)
            {
                this.transform.position = new Vector3((float)-126.3395, (float)-62.91042, -25);
            }
            else
            {
                this.transform.position = new Vector3(playertransform.position.x, (float)-62.91042, -25);
            }
        }
        else
        {
            this.transform.position = new Vector3(playertransform.position.x, playertransform.position.y, -25);
        }
    }
}
