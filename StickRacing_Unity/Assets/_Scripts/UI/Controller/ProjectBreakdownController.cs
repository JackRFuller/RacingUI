using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ProjectBreakdownController : MonoBehaviour {

    private C_Collectibles activeProject;

    [Header("UI Elements")]
    [SerializeField] private Text projectNameText;
    [SerializeField] private Image[] projectpartIcon = new Image[10];

    void OnEnable()
    {
        SetActiveProject();

      
    }

    void SetActiveProject()
    {
        activeProject = C_PlayerData.instance.projects[ProjectController.projectID];

        SetUIElements();
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

    public void CycleThroughProjects(bool _forward)
    {
        int _projectID = ProjectController.projectID;

        for(int i = 0; i < C_PlayerData.instance.projects.Length; i++)
        {
            if (_forward)
            {
                _projectID++;
                if (_projectID == C_PlayerData.instance.projects.Length)
                    _projectID = 0;
            }
            else
            {
                _projectID--;
                if (_projectID < 0)
                    _projectID = C_PlayerData.instance.projects.Length -1;
            }

            if (C_PlayerData.instance.projects[_projectID].hasCompleted)
            {
                activeProject = C_PlayerData.instance.projects[_projectID];
                ProjectController.projectID = _projectID;
                SetUIElements();
                break;
            }
        }
    }

    
}
