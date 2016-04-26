using UnityEngine;
using System.Collections;

public class OperativeItemGeneratorController : MonoBehaviour
{
    public static OperativeItemGeneratorController instance;

    private C_Operatives operative;

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
        for (int i = 0; i < 3; i++)
        {
            float _itemNum = Random.Range(0.0f, 100.0f);

            for (int j = 0; j < operative.inventoryChances.Count; j++)
            {
                if (_itemNum > operative.inventoryChances[j] && _itemNum <= operative.inventoryChances[j + 1])
                {
                    Debug.Log(_itemNum);
                    string _itemName = operative.inventory[j];
                    Debug.Log(_itemName);                     
                    break;                  
                }
            }
        }

       
    }
	
}
