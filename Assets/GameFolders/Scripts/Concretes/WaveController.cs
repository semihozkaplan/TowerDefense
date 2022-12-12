using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour
{
    
    public void StartWaveTime()
    {

        Timer _timer = FindObjectOfType<Timer>();
        _timer._timeStarter = true;

    }

}
