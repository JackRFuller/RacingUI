using UnityEngine;
using System.Collections;

public class SceneLoaderController : MonoBehaviour 
{
	
	[SerializeField] private GameObject navigationController;
	[SerializeField] private GameObject dataBar;
	[SerializeField] private GameObject mainHub;

	void Awake()
	{
		InitialiseUI();
	}

	void InitialiseUI()
	{
		

		if(NavigationController.instance == null)
		{
			GameObject _navController = Instantiate(navigationController);
			SetParent(_navController);
		}

		if(TopBarController.instance == null)
		{
			GameObject _databar = Instantiate(dataBar);
			SetParent(_databar);
		}

		if(MainHubController.instance == null)
		{
			GameObject _mainHub = Instantiate(mainHub);
			SetParent(_mainHub);
		}
	}

	void SetParent(GameObject _object)
	{
		_object.transform.parent = this.transform;
	}
}
