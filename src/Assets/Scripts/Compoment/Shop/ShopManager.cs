using UnityEngine;
using System.Collections;

public class ShopManager
{
    static ShopManager m_instance;
    public static ShopManager Instance
    {
        get
        {
            if (m_instance == null)
            {
                m_instance = new ShopManager();
            }
            return m_instance;
        }
    }
}
