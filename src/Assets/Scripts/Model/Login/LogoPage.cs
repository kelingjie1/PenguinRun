using UnityEngine;
using System.Collections;

public class LogoPage : BasePage
{
    static LogoPage m_instance;
    public static LogoPage Instance
    {
        get
        {
            if (m_instance==null)
            {
                m_instance = ResourceManager.Load("Prefab/Login/LogoPage").GetComponent<LogoPage>();
            }
            return m_instance;
        }
    }
}
