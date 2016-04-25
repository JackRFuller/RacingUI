using UnityEngine;
using System.Collections;

public class MainHubController : MonoBehaviour
{
	public static MainHubController instance;

	void Awake()
	{
		if(instance == null)
			instance = this;
		else if(instance != this)
			Destroy(gameObject);
	}

	void OnEnable()
	{
		if(!NavigationController.instance.loadedScreens.Contains(this.gameObject))
			NavigationController.instance.loadedScreens.Add(this.gameObject);
	}

	public void OnClick(string _target)
	{
		NavigationController.instance.OnClickNavigateTo(_target);
	}
}
