using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIForSAE : MonoBehaviour
{
    public void btn1( int a )
    {
        if( a == 1)
        {
            SceneManager.LoadScene("mainScene");
        }
        else if (a == 2)
        {
            SceneManager.LoadScene("end");
        }
        else if (a == 3)
        {
            SceneManager.LoadScene("Let'sGetStarted");
        }
    }

}
