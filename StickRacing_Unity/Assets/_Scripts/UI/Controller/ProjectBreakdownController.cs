using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ProjectBreakdownController : MonoBehaviour {

    private C_Collectibles activeProject;

    [Header("UI Elements")]
    [SerializeField] private Text projectNameText;
    [SerializeField] private Image[] projectpartIcon = new Image[10];


    void SetActiveProject()
    {
        activeProject = C_PlayerData.instance.projects[ProjectController.projectID];
    }

    void SetUIElements()
    {
        projectNameText.text = activeProject.m_projectName;

        for(int i = 0; i < projectpartIcon.Length; i++)
        {
            if (activeProject.m_hasUnlockedPiece[i])
                projectpartIcon[i].enabled = true;
            else projectpartIcon[i].enabled = false;
        }
    }
}
