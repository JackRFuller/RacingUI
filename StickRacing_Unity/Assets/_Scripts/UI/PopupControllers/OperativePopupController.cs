using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OperativePopupController : MonoBehaviour
{
    public static C_Operatives operative;

    [Header("UI Elements")]
    [SerializeField] private Text costText;

    //Operative Values
    private int cost;
    
    void Start()
    {
        LoadInOperativeDetails();
    } 
    
    void LoadInOperativeDetails()
    {
        cost = operative.m_cost;

        InitilizeUI();
    }  

    void InitilizeUI()
    {
        costText.text = cost.ToString();
    }

    public void OnClick_Purchase()
    {
        if(C_PlayerData.m_PlayerCash >= cost)
        {
            C_PlayerData.m_PlayerCash -= cost;            
        }
        else
        {
            Debug.Log("Not Enough Cash!");
        }
    }

    public void OnClick_Close()
    {
        Destroy(gameObject);
    }

}
