using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] private GameObject car;
    [SerializeField] private List<Transform> wayPoints;
    private bool _isTimerRunning, _canSpawnCar;
    
    void Start()
    {
        
    }

    private IEnumerator SpawnTimer()
    {
        if (!_isTimerRunning)
        {
            _isTimerRunning = true;
            yield return new WaitForSeconds(Random.Range(1, 40));
            _canSpawnCar = true;
            _isTimerRunning = false;
        }
    }

    void Update()
    {
        if (_canSpawnCar)
        {
            GameObject carPlaceholder = Instantiate(car, transform.position, transform.rotation);
            carPlaceholder.GetComponent<CarScript>().CarDestination = wayPoints[Random.Range(0, wayPoints.Count)];
            _canSpawnCar = false;
        }
        else
        {
            StartCoroutine(SpawnTimer());
        }
    }
}
