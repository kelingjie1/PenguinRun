using UnityEngine;
using System.Collections;

public class IceBlock : MonoBehaviour 
{
    public int rowId;
    public int columnId;
    public enum IceType
    {

    }
    UISprite IceSprite;
    UISprite PropSprite;
    IceType m_iceType;
    public IceType iceType
    {
        get
        {
            return m_iceType;
        }
        set
        {
            m_iceType = value;
        }
    }
    PropType m_propType;
    public PropType propType
    {
        get
        {
            return m_propType;
        }
        set
        {
            m_propType = value;
        }
    }
	void Awake () 
    {
        IceSprite = gameObject.FindChild("IceSprite").GetComponent<UISprite>();
        PropSprite = gameObject.FindChild("PropSprite").GetComponent<UISprite>();
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
}
