using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public GameObject FpsCounterText;
    void Awake()
    {
        DontDestroyOnLoad(FpsCounterText);
    }
}
