using UnityEngine;
using System.Collections;

public class TimerController : MonoBehaviour {

    public static TimerController instance;

    private float fuelTimer;
    private float fuelTimerEndPoint;
    private bool isRunningFuelTimer;

    private bool isCarUpgradeRunning;
    private float carUpgradeTimer;
    private float carUpgradeTimerEndPoint;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartFuelTimer(float _fuelTimerEndPoint)
    {
        fuelTimer = 0;
        fuelTimerEndPoint = _fuelTimerEndPoint;
        isRunningFuelTimer = true;
    }

    public void StartCarUpgradeTimer(float _timerEndPoint)
    {
        carUpgradeTimer = 0;
        carUpgradeTimerEndPoint = _timerEndPoint;
        isCarUpgradeRunning = true;
    }

    void Update()
    {
        if (isRunningFuelTimer)
            RunFuelTimer();

        if (isCarUpgradeRunning)
            RunUpgradeTimer();
    }

    void RunFuelTimer()
    {
        fuelTimer += Time.smoothDeltaTime;
        if(fuelTimer >= fuelTimerEndPoint)
        {
            isRunningFuelTimer = false;
            fuelTimer = 0;
            C_PlayerData.m_PlayerFuel += 1;
        }
    }

    void RunUpgradeTimer()
    {
        carUpgradeTimer += Time.deltaTime;
        if(carUpgradeTimer >= carUpgradeTimerEndPoint)
        {

        }
    }


}
