using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsToggleOn : MonoBehaviour
{
    public Text textEnable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject TogglerObject = GameObject.Find("TogglerObject");
        ToggleScript toggleScript = TogglerObject.GetComponent<ToggleScript>();
        if(toggleScript.isToggleOn = true)
        {
            textEnable.IsActive();
        }
    }
}
