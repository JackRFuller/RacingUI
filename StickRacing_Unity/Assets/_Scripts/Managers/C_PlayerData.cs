using UnityEngine;
using System.Collections;

public class C_PlayerData : MonoBehaviour
{

	public static C_PlayerData instance;

	public static int m_PlayerCash = 0;
	public static int m_PlayerCredits = 0;
	public static int m_PlayerLevel = 1;
	public static int m_PlayerFuel = 5;
	public static int m_PlayerFuelMax = 5;
	public static int m_PLayerXP = 0;

	public C_CarClasses[] carClasses = new C_CarClasses[4];

	void Awake()
	{
		if(instance == null)
			instance = this;
		else if(instance != null)
			Destroy(gameObject);
	}
}




