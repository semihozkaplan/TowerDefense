using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    TextMeshProUGUI _timeText;

    public float _timeRemain = 15;
    public bool _timeStarter = false;
    public bool TimeStarter => _timeStarter;

    private void Awake()
    {

        _timeText = GetComponent<TextMeshProUGUI>();

    }

    private void Start()
    {

        _timeStarter = false;

    }

    private void Update()
    {

        if (_timeStarter)
        {

            if (_timeRemain > 0)
            {

                _timeRemain -= Time.deltaTime;
                DisplayTime(_timeRemain);

            }

            else
            {

                Debug.Log("Time is out!!!");
                _timeRemain = 0;
                _timeStarter = false;

            }

        }

    }

    private void DisplayTime(float time)
    {

        time += 1; // Oyun başlar başlamaz saniyeden düşmesin diye burada bir ekleme işlemi yaptık.
        float seconds = Mathf.FloorToInt(time % 60);
        _timeText.text = seconds.ToString();

    }

}
