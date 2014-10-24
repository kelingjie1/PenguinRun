using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{
    public bool running;
    public int Speed = Setting.Instance.defaultSetting.GetInt("StartSpeed");

    GameObject Map;
    GameObject Mountain;
    GameObject River;
	void Awake()
    {
        Map = gameObject.FindChild("Map");
        Mountain = gameObject.FindChild("Mountain");
        River = gameObject.FindChild("River");
        
    }
	void Update () 
    {
        if (running)
        {
            Map.transform.localPosition = new Vector3(0, Map.transform.localPosition.y - Time.deltaTime * Speed, 0);
            int mountainy = (int)(Map.transform.localPosition.y / Screen.height);
            Mountain.transform.localPosition = new Vector3(0, -mountainy * Screen.height, 0);
        }
	}
}
