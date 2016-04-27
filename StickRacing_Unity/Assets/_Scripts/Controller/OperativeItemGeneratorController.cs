using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OperativeItemGeneratorController : MonoBehaviour
{
    public static OperativeItemGeneratorController instance;

    private C_Operatives operative;

    private string[,] generatedItems = new string[2, 3];

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(gameObject);
    }

    public void StartItemGeneration(C_Operatives _operative)
    {
        operative = _operative;
        operative.AddValuesToList();
        operative.AddInventoryToDictionary();

        ItemGeneration();
    }

    void ItemGeneration()
    {
        List<string> generatedItems = new List<string>();        

        for (int i = 0; i < 3; i++)
        {
            float _itemNum = Random.Range(0.0f, 100.0f);

            for (int j = 0; j < operative.inventoryChances.Count; j++)
            {
                if (_itemNum > operative.inventoryChances[j] && _itemNum <= operative.inventoryChances[j + 1])
                {
                    string _itemName = operative.inventory[j];
                                    
                                         
                    break;                  
                }
            }
        }
    }

    void DetermineItem(string _item)
    {
        switch (_item)
        {
            case ("Credits"):

                break;
            case ("Fuel"):
                break;
            case ("Collectible"):
                break;
            case ("Upgrade"):
                break;
            case ("Boosters"):
                break;
        }
    }

    int DetermineCreditQuantity()
    {
        float _quantityRN = Random.Range(0.0f, 100.0f);
        int _quantity = 0;

        for(int i = 0; i < operative.creditQuantityChances.Length; i++)
        {
            if(_quantityRN > operative.creditQuantityChances[i] && _quantityRN <= operative.creditQuantityChances[i + 1])
            {
                _quantity = operative.creditQuantities[i];
            }
        }

        return _quantity;
    }
	
}
