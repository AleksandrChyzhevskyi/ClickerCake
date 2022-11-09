using UnityEngine;
using UnityEngine.Events;

public class PlayerWallet : MonoBehaviour
{
    private int _bakedCakes;

    public event UnityAction<int> CakeBalanceChenget;
    public int BakedCakEs => _bakedCakes;
    
    public void addCakeProfit(int amount)
    {
        _bakedCakes += amount;
        CakeBalanceChenget?.Invoke(_bakedCakes);
    }
    public void WithdrawCakes(int amount)
    {
        _bakedCakes -= amount;
        CakeBalanceChenget?.Invoke(_bakedCakes);
    }
}
