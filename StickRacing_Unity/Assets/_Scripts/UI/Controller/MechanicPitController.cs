using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MechanicPitController : MonoBehaviour {

	[Header("Upgrade Data")]
	[SerializeField] private C_CarUpgrades[] upgradeData;
	private int activeCarClass = 0;
    private C_CarClasses carClass;

	[Header("UI Elements")]
	[SerializeField] private Text carClassText;
	[SerializeField] private Text[] upgradeLevelTexts = new Text[4];
	[SerializeField] private Text[] upgradeCostTexts = new Text[4];

    void OnEnable()
    {
        SetUIValues();
    }

	void SetUIValues()
	{
		carClass = C_PlayerData.instance.carClasses[activeCarClass];

		carClassText.text = carClass.name;

		for(int i = 0; i < upgradeLevelTexts.Length; i++)
		{
			upgradeLevelTexts[i].text = carClass.upgradeLevels[i].ToString();
		}

		for(int i = 0; i < upgradeCostTexts.Length; i++)
		{
			upgradeCostTexts[i].text = upgradeData[activeCarClass].upgradeLevels[carClass.upgradeLevels[i]].upgradeCost.ToString();
		}
	}

	public void OnClick_CycleThroughCarClasses(bool _goingForward)
	{
        int _carClass = activeCarClass;

        for(int i = 0; i < C_PlayerData.instance.carClasses.Length; i++)
        {
            if (_goingForward)
            {
                _carClass++;
                if (_carClass == C_PlayerData.instance.carClasses.Length)
                    _carClass = 0;
            }
            else
            {
                _carClass--;
                if (_carClass < 0)
                    _carClass = C_PlayerData.instance.carClasses.Length - 1;
            }

            if (C_PlayerData.instance.carClasses[_carClass].unlocked)
            {
                activeCarClass = _carClass;
                SetUIValues();
                break;
            }
        }
	}

    public void InitiateUpgrade(int _upgradeCategory)
    {

    }
}