using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinsCounter : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _text;

    private void OnEnable()
    {
        _player.CoinCollected += RefreshCoinsCounter;
    }

    private void OnDisable()
    {
        _player.CoinCollected -= RefreshCoinsCounter;
    }

    private void RefreshCoinsCounter(int coins)
    {
        _text.text = coins.ToString();
    }
}
