using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//导入UI包

public class TankList : MonoBehaviour {
    public Texture[] tanklist;
    public int number;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

    void Awake()
    {
        change(number);
    }

    public void change(int number1)
    {
        if (number1 == 1)
        {
            number--;
            if (number < 0)
            {
                number = 2;
            }
            number1 = number;
        }
        else if(number1 == -1)
        {
            number++;
            if (number >2)
            {
                number = 0;
            }
            number1 = number;
        }
        RawImage rawimage = gameObject.GetComponent<RawImage>();
        rawimage.texture = tanklist[number1];
    }
}
