using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CarClassesController : MonoBehaviour {

	[Header("Upgrade Data")]
	[SerializeField] private C_CarUpgrades[] upgradeData;
	private int activeCarClass = 0;

	[Header("UI Elements")]
	[SerializeField] private Text carClassText;
	[SerializeField] private Text[] upgradeLevelTexts = new Text[4];
	[SerializeField] private Text[] upgradeCostTexts = new Text[4];



	void SetUIValues()
	{
		C_CarClasses _carClass = C_PlayerData.instance.carClasses[activeCarClass];

		carClassText.text = _carClass.name;

		for(int i = 0; i < upgradeLevelTexts.Length; i++)
		{
			upgradeLevelTexts[i].text = _carClass.upgradeLevels[i].ToString();
		}

		for(int i = 0; i < upgradeCostTexts.Length; i++)
		{
			upgradeCostTexts[i].text = upgradeData[activeCarClass].upgradeLevels[_carClass.upgradeLevels[i]].upgradeCost.ToString();
		}
	}

	public void OnClick_CycleThroughCarClasses(bool _goingForward)
	{
		if(_goingForward)
		{
			activeCarClass++;
			if(activeCarClass > 3)
				activeCarClass = 0;
		}
		else
		{
			activeCarClass--;
			if(activeCarClass < 0)
				activeCarClass = 3;
		}
			
		SetUIValues();

	}
}