using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//导入UI包

public class GameManager : SingletonMono<GameManager>
{
    public GameManager instance = null;
    public bool isGameOver = false;
    public int point = 0;
    public string ID = "";
    public InputField IdInput;
    public Texture PlayerTexture;

    void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != this) Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

   
}
