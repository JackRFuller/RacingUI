using UnityEngine;
using System.Collections;

public class GarageController : MonoBehaviour {

	public void OnClickNavigation(string _targetDestination)
	{
		NavigationController.instance.OnClickNavigateTo(_targetDestination);
	}
}
