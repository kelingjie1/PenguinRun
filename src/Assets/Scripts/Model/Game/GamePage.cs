using UnityEngine;
using System.Collections;

public class GamePage : BasePage 
{
    static GamePage m_instance;
    public static GamePage Instance
    {
        get
        {
            if (m_instance == null)
            {
                m_instance = Resources.Load<GameObject>("Prefab/Game/GamePage").Instantiate().GetComponent<GamePage>();
            }
            return m_instance;
        }
    }
}
