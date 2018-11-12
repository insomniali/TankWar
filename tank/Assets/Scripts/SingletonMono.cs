using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 单例模板
/// </summary>
public class SingletonMono<T> :  MonoBehaviour where T : Component
{

    private static T _instance;
    public static  T Instance
    {
        get
        {
            if (_instance == null)
            {
                //  Singleton<T> g = new Singleton<T>();
             
                _instance = FindObjectOfType(typeof(T)) as T;//找到在场景中激活的有挂载这个脚本的物体
                if (_instance == null)
                {
                    Debug.Log("obj");
                    GameObject obj = new GameObject();//
                    obj.hideFlags = HideFlags.HideAndDontSave;//隐藏实例化的new game object，下同  
                    _instance = (T)obj.AddComponent(typeof(T));//在新建的gameobject下挂载这个单例
                }
            }
            return _instance;
        }
    }
}
