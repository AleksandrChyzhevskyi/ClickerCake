using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class WolletDispley : MonoBehaviour
{
    [SerializeField] private PlayerWallet _playerWallet;
    [SerializeField] private TMP_Text _cakeDisplay;

    private void OnEnable()
    {
        _playerWallet.CakeBalanceChenget += OnCakeBalanceChenget;
    }

    private void OnDisable()
    {
        _playerWallet.CakeBalanceChenget -= OnCakeBalanceChenget;
    }

    private void OnCakeBalanceChenget(int cakeBalence)
    {
        _cakeDisplay.text = cakeBalence.ToString();
    }    
}
