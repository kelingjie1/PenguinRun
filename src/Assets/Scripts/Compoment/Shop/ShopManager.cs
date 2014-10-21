using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum ShopError
{
    None,
    CannotOffer,    //买不起
    NoEnoughProp,   //库存商品不足
    CustomError,    //自定义错误
}
public interface IShopInterface
{
    //充值
    void Recharge(int count);
    void BuyProp(int id, int count, ShopError error);

    void PropCountChange(int id, int oldcount, int newcount);
}
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

    public IShopInterface shopDelegate;
    List<BaseProp> m_propList = new List<BaseProp>();
    public List<BaseProp> PropList
    {
        get
        {
            return m_propList;
        }
    }
    public void AddProp(BaseProp prop)
    {
        m_propList.Add(prop);
    }
    public ShopError BuyProp(int id, int count = 1)
    {
        ShopError error = m_propList[id].Buy();
        if (shopDelegate!=null)
        {
            shopDelegate.BuyProp(id, count, error);
        }
        return error;
    }
    
    public void ChangePropCount(int id,int newcount)
    {
        int oldcount = m_propList[id].count;
        m_propList[id].count = newcount;
        if (shopDelegate != null)
        {
            shopDelegate.PropCountChange(id, oldcount, newcount);
        }
    }

    public void Rechange(int count)
    {
        if (shopDelegate != null)
        {
            shopDelegate.Recharge(count);
        }
    }
    
}
