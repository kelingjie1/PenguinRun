using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseGoods
{
    public int id;
    public string name;
    public int count;
    public Dictionary<int, int> cost = new Dictionary<int, int>();
    public virtual ShopError CanBuy()
    {
        foreach (KeyValuePair<int,int> item in cost)
        {
            if (ShopManager.Instance.GoodsList[item.Key].count<item.Value)
            {
                return ShopError.CannotOffer;
            }
        }
        return ShopError.None;
    }
    public virtual ShopError Buy()
    {
        ShopError error = CanBuy();
        if (error!=ShopError.None)
        {
            return error;
        }

        foreach (KeyValuePair<int, int> item in cost)
        {
            ShopManager.Instance.ChangeGoodsCount(item.Key, ShopManager.Instance.GoodsList[item.Key].count - item.Value);
        }
        return ShopError.None;
    }
}
