using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private int _coins = 0;

    public event UnityAction<int> CoinCollected;

    public void CollectCoin()
    {
        _coins++;

        CoinCollected?.Invoke(_coins);
    }
}
