using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//导入UI包

public class Player : MonoBehaviour {
    public int Life;
    public int Lv;
    public GameManager thisgame;
    public int NeedExp;
    public int HaveExp;
    public int Point;
    public int BulletNum;
    public int Direction;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    Texture2D Texture2Texture2D(Texture texture)
    {

        Texture2D texture2D = new Texture2D(texture.width, texture.height, TextureFormat.RGBA32, false);
        RenderTexture currentRT = RenderTexture.active;
        RenderTexture renderTexture = RenderTexture.GetTemporary(texture.width, texture.height, 32);
        Graphics.Blit(texture, renderTexture);
        RenderTexture.active = renderTexture;
        texture2D.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
        texture2D.Apply();
        RenderTexture.active = currentRT;
        RenderTexture.ReleaseTemporary(renderTexture);
        return texture2D;

    }


    void Awake()
    {
        Texture2D texture= Texture2Texture2D(GameManager.Instance.PlayerTexture);
        Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
        GameObject.Find("Player").GetComponent<SpriteRenderer>().sprite = sprite;

        GameObject.Find("Canvas/LifeShow").GetComponent<Text>().text = "Life:"+Life.ToString();
        GameObject.Find("Canvas/LvShow").GetComponent<Text>().text = "Lv:" + Lv.ToString();
        GameObject.Find("Canvas/IDShow").GetComponent<Text>().text = "ID:" + GameManager.Instance.ID;
        GameObject.Find("Canvas/ExpShow").GetComponent<Text>().text = "Exp:" + HaveExp.ToString()+"/"+NeedExp.ToString();
        GameObject.Find("Canvas/PointShow").GetComponent<Text>().text = "Point:" + Point.ToString();
        GameObject.Find("Canvas/BulletShow").GetComponent<Text>().text = "Bullet:" + BulletNum.ToString();
    }

}
