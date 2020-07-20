using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Vector2 _groundLayer;
    [SerializeField] private Vector2 _extrasLayer;
    [SerializeField] private Vector2 _distinctionToSpawn;

    [SerializeField] private float _delayToSpawn;

    [SerializeField] private GameObject _coinsTemplate;
    [SerializeField] private GameObject _obstacleTemplate;
    [SerializeField] private GameObject _platformTemplate;


    private Vector2 _nextPositionToSpawn = Vector2.zero;

    private float _elapsedTime = 0;


    private void Update()
    {
        if (_elapsedTime >= _delayToSpawn)
        {
            SpawnPlatform();

            SpawnExtras();

            _nextPositionToSpawn += _distinctionToSpawn;
            _elapsedTime = 0;
        }

        _elapsedTime += Time.deltaTime;
    }

    private void SpawnPlatform()
    {
        Vector2 position = _groundLayer + _nextPositionToSpawn;
        Instantiate(_platformTemplate, position, Quaternion.identity);
    }

    private void SpawnExtras()
    {
        Vector2 position = _extrasLayer + _nextPositionToSpawn;

        if (Random.value >= 0.5)
            Instantiate(_coinsTemplate, position, Quaternion.identity);
        else
            Instantiate(_obstacleTemplate, position, Quaternion.identity);
    }
}
