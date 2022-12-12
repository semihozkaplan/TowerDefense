using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaveSpawner : MonoBehaviour
{

    public GameObject _enemyPrefab;
    public Transform _spawnPos;
    Timer _timer;

    public float _timeCountForWave = 4f;
    private float _currentTime;

    private int _waveIndex = 1;

    private void Start()
    {

        _timer = FindObjectOfType<Timer>();

    }

    private void Update()
    {

        _currentTime += Time.deltaTime;

        if (_currentTime > _timeCountForWave)
        {

            if (_timer.TimeStarter)
            {

                StartCoroutine(SpawnWave());
                _currentTime = 0f;
            
            }

        }

    }

    private IEnumerator SpawnWave()
    {

        for (int i = 0; i < _waveIndex; i++)
        {

            SpawnEnemy();
            yield return new WaitForSeconds(0.8f);

        }

        _waveIndex++;

    }

    private void SpawnEnemy()
    {

        Instantiate(_enemyPrefab, _spawnPos.position, _spawnPos.rotation);

    }

}
