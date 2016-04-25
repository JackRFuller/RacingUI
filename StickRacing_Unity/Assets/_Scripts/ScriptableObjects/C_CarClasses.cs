using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "UpgradeData", menuName = "Data Objects/Car Class", order = 1)]
public class C_CarClasses : ScriptableObject
{
	public string className;
	public bool unlocked;
	public int[] upgradeLevels =  new int[4]; //Upgrade Levels are in the following order (from top to bottom): Top Speed, Handling, Traction, Acceleration

}
