using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "UpgradeData", menuName = "Data Objects/Upgrade Data", order = 1)]
public class C_CarUpgrades : ScriptableObject
{
	[System.Serializable]
	public class carUpgrade
	{
		public int upgradeCost;
		public float upgradeWaitTime;
	}

	public carUpgrade[] upgradeLevels = new carUpgrade[10];

}
