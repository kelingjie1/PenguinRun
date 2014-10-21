using UnityEngine;
using System.Collections;

public class Setting
{
    static Setting m_instance;
    public static Setting Instance
    {
        get
        {
            if (m_instance == null)
            {
                m_instance = new Setting();
            }
            return m_instance;
        }
    }
    Setting()
    {
        TextAsset defaultSettingAsset = Resources.Load("Text/DefaultSetting.txt") as TextAsset;
        defaultSetting = new SettingReader();
        if (defaultSettingAsset==null)
        {
            Debug.LogError("defaultSetting is not exist");
        }
        else
        {
            defaultSetting.LoadFromString(defaultSettingAsset.text);
        }
        
    }

    public SettingReader defaultSetting;
    public SettingReader currentSetting;
}
