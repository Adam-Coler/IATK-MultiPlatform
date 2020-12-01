using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using UnityEngine.UI;


public class addMenuControls : MonoBehaviour
{
    #region CUSTOM

#if DESKTOP

#elif HL2



#elif VIVE

    //[HideInInspector]
    //public static SteamVR_Behaviour_Pose NonDominantDeviceBehaviourPose;

    //private void Start()
    //{
    //    NonDominantDeviceBehaviourPose = FindObjectsOfType<SteamVR_Behaviour_Pose>().First(x => x.inputSource == SteamVR_Input_Sources.LeftHand);

    //    this.gameObject.AddComponent<SteamVR_Behaviour_Pose>();

    //}

    [HideInInspector]
    public static SteamVR_Behaviour_Pose PrimaryDeviceBehaviourPose;

    [SerializeField]
    public GameObject contollerPrefab;

    private GameObject controller;

    /// <summary>Provide the SteamVR_Input_Source related to the non-dominant controller.</summary>

    /// <summary>Assign the SteamVR Behaviour Poses for each hand.</summary>
    /// <remarks>
    /// By default, the right hand is set as the primary device and the left hand is the non-dominant
    /// device to avoid null reference exceptions.
    /// </remarks>
    private void Start()
    {
        controller = Instantiate(contollerPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        SteamVR_Actions.logitechToolkit_PrimaryClick.AddOnStateDownListener(TriggerPressed, SteamVR_Input_Sources.LeftHand);
        
    }

    private void TriggerPressed(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        //GameObject[] buttonTagedObjects = GameObject.FindGameObjectsWithTag("Button");
        //Debug.Log(buttonTagedObjects.Length);
        //foreach (GameObject obj in buttonTagedObjects)
        //{
        //    Button btn = obj.GetComponent<Button>();
        //    if (btn != null)
        //    {
        //        btn.Select();
        //        btn.onClick.Invoke();
        //        Debug.Log(btn.name);
        //    }
        //}
        //Debug.Log(fromSource);


    }

#else


#endif
    #endregion
}
