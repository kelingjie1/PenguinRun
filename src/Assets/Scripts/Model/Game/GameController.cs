using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public enum GameType
{
    Tap,
}
public class GameController : MonoBehaviour 
{
    static GameController m_instance;
    public static GameController Instance
    {
        get
        {
            return m_instance;
        }
    }

    public GameType gameType=GameType.Tap;
    public bool running;
    public int speed;

    GameObject map;
    GameObject mountain;
    River river;

	void Awake()
    {
        m_instance = this;
        map = gameObject.FindChild("Map");
        mountain = gameObject.FindChild("Mountain");
        river = gameObject.FindChild("River").GetComponent<River>();
        speed = Setting.Instance.defaultSetting.GetInt("StartSpeed");
        
    }
    void Start()
    {
        river.CreateMap();
    }
	void Update () 
    {
        if (running)
        {
            map.transform.localPosition = new Vector3(0, map.transform.localPosition.y - Time.deltaTime * speed, 0);
            int mountainy = (int)(map.transform.localPosition.y / Screen.height);
            mountain.transform.localPosition = new Vector3(0, -mountainy * Screen.height, 0);
        }
	}
}
