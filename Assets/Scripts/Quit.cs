﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
  public void doquit()
    {
        Debug.Log("Application Closed");
        Application.Quit();
    }
}
