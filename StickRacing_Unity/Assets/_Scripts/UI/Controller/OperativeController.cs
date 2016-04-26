using UnityEngine;
using System.Collections;

public class OperativeController : MonoBehaviour {

	[SerializeField] private GameObject operativePopup;

    [Header("Operative Data")]
    [SerializeField] private C_Operatives[] operativeData;

    public void OnClick_LoadInPopup(int _operativeID)
    {
        Instantiate(operativePopup);
        OperativePopupController.operative = operativeData[_operativeID];
    }


}
