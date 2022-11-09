using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Cake", menuName = "Cake Item", order =51)]
public class CakeShopItem : ScriptableObject
{
    [SerializeField] private Cake _cake;
    [SerializeField] private string _lable;
    [SerializeField] private Sprite _icon;
    [SerializeField] private int _price;
    [SerializeField] private bool _isBuy;

    public bool IsBut => _isBuy;

    public string Label => _lable;
    public Cake Cake => _cake;
    public Sprite Icon => _icon;
    public int Price => _price;
    public int CakeProfit => _cake.Profit;

    public void Buy()
    {
        _isBuy = true;
    }
}
