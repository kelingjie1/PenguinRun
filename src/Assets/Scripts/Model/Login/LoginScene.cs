using UnityEngine;
using System.Collections;

public class LoginScene : MonoBehaviour 
{
    void Awake()
    {
        PageManager.Instance.ShowPage(LogoPage.Instance);
    }
}
