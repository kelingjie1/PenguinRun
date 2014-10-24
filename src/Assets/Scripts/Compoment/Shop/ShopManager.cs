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
    void BuyGoods(int id, int count, ShopError error);

    void GoodsCountChange(int id, int oldcount, int newcount);
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
    List<BaseGoods> m_goodsList = new List<BaseGoods>();
    public List<BaseGoods> GoodsList
    {
        get
        {
            return m_goodsList;
        }
    }
    public void AddGoods(BaseGoods goods)
    {
        m_goodsList.Add(goods);
    }
    public ShopError BuyGoods(int id, int count = 1)
    {
        ShopError error = m_goodsList[id].Buy();
        if (shopDelegate!=null)
        {
            shopDelegate.BuyGoods(id, count, error);
        }
        return error;
    }

    public void ChangeGoodsCount(int id, int newcount)
    {
        int oldcount = m_goodsList[id].count;
        m_goodsList[id].count = newcount;
        if (shopDelegate != null)
        {
            shopDelegate.GoodsCountChange(id, oldcount, newcount);
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
