using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightManager : MonoBehaviour
{
    [SerializeField] private List<TrafficLight> TrafficLights;
    private bool _nextStopLight;
    private bool _isTimerRunning;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_nextStopLight)
        {
            if (!TrafficLights[0]._isRedLight)
            {
                TrafficLights[0]._isRedLight = true;
                TrafficLights[1]._isRedLight = false;
            }
            else if (!TrafficLights[1]._isRedLight)
            {
                TrafficLights[1]._isRedLight = true;
                TrafficLights[2]._isRedLight = false;
            }
            else if (!TrafficLights[2]._isRedLight)
            {
                TrafficLights[2]._isRedLight = true;
                TrafficLights[3]._isRedLight = false;
            }
            else if (!TrafficLights[3]._isRedLight)
            {
                TrafficLights[3]._isRedLight = true;
                TrafficLights[0]._isRedLight = false;
            }
            _nextStopLight = false;
        }

        else
        {
            StartCoroutine(TrafficTimer());
        }
    }

    private IEnumerator TrafficTimer()
    {
        if (!_isTimerRunning)
        {
            _isTimerRunning = true;
            yield return new WaitForSeconds(4);
            _nextStopLight = true;
            _isTimerRunning = false;
        }
    }
}
