using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TopBarController : MonoBehaviour
{
	public static TopBarController instance;

	[Header("UI Elements")]
	[SerializeField] private Text playerCashText;
	[SerializeField] private Text playerCreditsText;
	[SerializeField] private Image[] fuelIconImages = new Image[10];
	[SerializeField] private Text playerLevelText;
	[SerializeField] private Image playerXPBarImage;

	void Awake()
	{
		if(instance == null)
			instance = this;
		else if(instance != this)
			Destroy(gameObject);
	}

	void Start()
	{
		InitialiseUI();
	}

	public void InitialiseUI()
	{
		UpdatePlayerCashText();
		UpdatePlayerCreditText();
		UpdatePlayerFuelImages();
		UpdatePlayerLevelText();
	}

	public void UpdatePlayerCashText()
	{
		playerCashText.text = C_PlayerData.m_PlayerCash.ToString();
	}

	public void UpdatePlayerCreditText()
	{
		playerCreditsText.text = C_PlayerData.m_PlayerCredits.ToString();
	}

	public void UpdatePlayerLevelText()
	{
		playerLevelText.text = C_PlayerData.m_PlayerLevel.ToString();
	}

	public void UpdatePlayerFuelImages()
	{
		for(int i = 0; i < C_PlayerData.m_PlayerFuelMax; i++)
		{
			fuelIconImages[i].enabled = true;
		}
	}

    public void TravelBack()
    {
        NavigationController.instance.NavigateToPreviousScreen();
    }

}
