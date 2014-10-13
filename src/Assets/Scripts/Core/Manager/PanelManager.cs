using UnityEngine;
using System.Collections;

public class PanelManager :BaseView
{
    static PanelManager m_instance;
    public static PanelManager instance
    {
        get
        {
            return m_instance;
        }
    }
    void Awake()
    {
        m_instance = this;
    }
}
