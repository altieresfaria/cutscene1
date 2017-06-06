
using UnityEngine;

public class CutSceneEvents : MonoBehaviour

{
    public void CameraAcabou()
    {
        Debug.Log("E");
        CutSceneController.instancia.ProximaCamera(); 


    }

}