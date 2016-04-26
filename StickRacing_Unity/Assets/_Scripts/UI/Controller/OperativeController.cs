using UnityEngine;
using System.Collections;

public class OperativeController : MonoBehaviour
{
    public static OperativeController instance;


	[SerializeField] private GameObject operativePopup;    

    [Header("Operative Data")]
    public C_Operatives[] operativeData;


    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    public void OnClick_LoadInPopup(int _operativeID)
    {
        Instantiate(operativePopup);
        OperativePopupController.operative = operativeData[_operativeID];
    }


}
