using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//导入UI包
using UnityEngine.SceneManagement;

public class IDText : MonoBehaviour {

    public GameManager thisgame;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Awake()
    {
        
        GameObject.Find("Canvas/ID").GetComponent<Text>().text = "ID:"+GameManager.Instance.ID;
    }
  }
