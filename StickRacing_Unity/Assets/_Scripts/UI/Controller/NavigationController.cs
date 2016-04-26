using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NavigationController : MonoBehaviour
{
	public static NavigationController instance;

	[SerializeField] private GameObject[] navScreens;
	[HideInInspector] public List<GameObject> loadedScreens;
	private GameObject previousScreen;
	private GameObject currentScreen;
    private List<GameObject> traveledScreens;
    private int travelScreenID = 0;


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
        loadedScreens = new List<GameObject>();
        traveledScreens = new List<GameObject>();

        currentScreen = MainHubController.instance.gameObject;
        traveledScreens.Add(currentScreen);      
        
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
        currentScreen = _newActiveScreen;
        traveledScreens.Add(currentScreen);
        travelScreenID++;
        Debug.Log(currentScreen.name);
	}

	public void NavigateToPreviousScreen()
	{
        if(traveledScreens.Count >= 1)
        {
            traveledScreens[travelScreenID].SetActive(false);
            traveledScreens.Remove(currentScreen);
            travelScreenID--;
            traveledScreens[travelScreenID].SetActive(true);
            currentScreen = traveledScreens[travelScreenID];
        }       

        

	}
}
