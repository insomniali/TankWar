using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//导入UI包。
using UnityEngine.SceneManagement;


public class StartButton : MonoBehaviour {

    void Awake()
    {
        Button button = gameObject.GetComponent<Button>() as Button;//获取Button组件
        button.onClick.AddListener(myClick);//为button的OnClick事件添加监听器，当监听到Click事件时，回调myClick函数。
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void myClick()
    {

        Debug.Log(3);
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Room")
            Application.LoadLevel(3);
    }
}
