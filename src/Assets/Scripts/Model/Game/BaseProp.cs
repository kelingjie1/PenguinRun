using UnityEngine;
using System.Collections;

public enum PropType
{
    None,
    IncreaseSpeed,
    DecreaseSpeed,
    IncreaseBlock,
    DecreaseBlock,
    RepairBlock,
    DestroyBlock,
    Bomb,
    Gold,
    Diamond
}
public class BaseProp : MonoBehaviour 
{
    string name;
}

public class IncreaseSpeedProp : BaseProp
{

}
