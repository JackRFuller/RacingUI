using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Project", menuName = "Data Objects/Project Data", order = 1)]
public class C_Collectibles : ScriptableObject
{
    public string m_projectName;
    public bool hasCompleted;
    public bool[] m_hasUnlockedPiece = new bool[10];
	
}
