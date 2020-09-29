using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject cutSceneCam;

    private void OnTriggerEnter(Collider other)
    {
        cutSceneCam.SetActive(true);
        thePlayer.SetActive(false);
    }
}
