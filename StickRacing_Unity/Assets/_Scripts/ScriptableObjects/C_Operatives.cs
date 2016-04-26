using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Operative", menuName = "Data Objects/Operative Data", order = 1)]
public class C_Operatives : ScriptableObject
{

    public string m_operativeName;
    public int m_cost;

    [Header("Inventory Chances - Must Add up to 100")]
    [SerializeField] private float creditsChance;
    [SerializeField] private float fuelChance;
    [SerializeField] private float collectibleChance;
    [SerializeField] private float carUpgradeChance;
    [SerializeField] private float boosterChance;

    [HideInInspector] public List<float> inventoryChances = new List<float>();
    public Dictionary<int, string> inventory = new Dictionary<int, string>();    
     
    public void AddValuesToList()
    {
        inventoryChances.Add(creditsChance);
        inventoryChances.Add(fuelChance);
        inventoryChances.Add( collectibleChance);
        inventoryChances.Add(carUpgradeChance);
        inventoryChances.Add(boosterChance);
    }

    public void AddInventoryToDictionary()
    {
        inventory.Add(0,"Credits");
        inventory.Add(1,"Fuel");
        inventory.Add(2,"Collectible");
        inventory.Add(3,"Car Upgrades");
        inventory.Add(4,"Boosters");

    }
}
