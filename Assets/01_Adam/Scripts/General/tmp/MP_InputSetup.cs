using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

namespace Photon_IATK
{

    public class MP_InputSetup : MonoBehaviour
    {

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log(GlobalVariables.green + "Setting up room inputs" + GlobalVariables.endColor + " : " + this.GetType().Name);
            setup();
        }

        // Update is called once per frame
        void Update()
        {

        }

#if DESKTOP

#elif HL2

#elif VIVE

        private void setup()
        {
            SteamVR_Behaviour_Pose SteamVR_Behaviour_Pose;
            SteamVR_Behaviour_Pose = this.gameObject.AddComponent<SteamVR_Behaviour_Pose>();

            SteamVR_Behaviour_Single SteamVR_Behaviour_Single;
            SteamVR_Behaviour_Single = this.gameObject.AddComponent<SteamVR_Behaviour_Single>();

            SteamVR_Behaviour_Vector2 SteamVR_Behaviour_Vector2;
            SteamVR_Behaviour_Vector2 = this.gameObject.AddComponent<SteamVR_Behaviour_Vector2>();

            SteamVR_Behaviour_Vector3 SteamVR_Behaviour_Vector3;
            SteamVR_Behaviour_Vector3 = this.gameObject.AddComponent<SteamVR_Behaviour_Vector3>();

            SteamVR_Behaviour_Skeleton SteamVR_Behaviour_Skeleton;
            SteamVR_Behaviour_Skeleton = this.gameObject.AddComponent<SteamVR_Behaviour_Skeleton>();

        }

#else

#endif
    }
}

