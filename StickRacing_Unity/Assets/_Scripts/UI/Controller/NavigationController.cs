using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NavigationController : MonoBehaviour
{
	public static NavigationController instance;

	[SerializeField] private GameObject[] navScreens;
	[HideInInspector] public List<GameObject> loadedScreens = new List<GameObject>();
	private GameObject previousScreen;
	private GameObject currentScreen;


	void Awake()
	{
		if(instance == null)
			instance = this;
		else if(instance != null)
			Destroy(gameObject);
	}

	void Start()
	{
		Init();
	}

	void Init()
	{
		currentScreen = MainHubController.instance.gameObject;
	}

	public void OnClickNavigateTo(string _target)
	{
		
		bool _hasScreen = false;

		for(int i = 0; i < loadedScreens.Count; i++)
		{
			if(loadedScreens[i].name == _target)
			{
				SetNewActiveScreen(loadedScreens[i]);
				_hasScreen = true;
				break;
			}
		}

		if(!_hasScreen)
		{
			LoadInScreen(_target);
		}
	}

	void LoadInScreen(string _target)
	{
		for(int i = 0; i < navScreens.Length;i++)
		{
			if(navScreens[i].name == _target)
			{
				GameObject _newScreen = Instantiate(navScreens[i]);
				loadedScreens.Add(_newScreen);
				SetNewActiveScreen(_newScreen);
				break;
			}
				
			
		}
			
	}

	void SetNewActiveScreen(GameObject _newActiveScreen)
	{
		currentScreen.SetActive(false);
		previousScreen = currentScreen;
		currentScreen = _newActiveScreen;
	}

	public void NavigateToPreviousScreen()
	{
		SetNewActiveScreen(previousScreen);
	}
}
