using UnityEngine;
using System.Collections;

public class ProjectMenuController : MonoBehaviour {

	public void OpenProject(int _projectID)
    {
        ProjectController.projectID = _projectID;
        NavigationController.instance.OnClickNavigateTo("ProjectBreakdown");
    }
}
