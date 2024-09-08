using BepInEx;
using UnityEngine;
using System.Collections;

[BepInPlugin("com.ntkernel.GorillaTag.DeepFryCamera", "DeepFry Camera", "1.0.0")]
public class DisableDeepFryCamera : BaseUnityPlugin
{
    private void Start()
    {
       
        StartCoroutine(DeepFryCameraIn(2f));
    }

    private IEnumerator DeepFryCameraIn(float delay)
    {
        
        yield return new WaitForSeconds(delay);

        
        var deepFryCamera = GameObject.Find("Third Person Camera");

        if (deepFryCamera != null)
        {
           
            deepFryCamera.SetActive(false);
            Logger.LogInfo("Deepfry gone >:(.");
        }
        else
        {
            Logger.LogError("Couldnt find Deep Fry target.");
        }
    }
}
