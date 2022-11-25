using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalGUIState : MonoBehaviour
{
    public GameObject UIElement;
    
    // Start is called before the first frame update
    void Start()
    {
        
}

    void Update() {

        
    }

    void OnTriggerEnter(Collider other)
    {
        if (!UIElement.activeSelf){
            UIElement.SetActive(true);
        }
       
    }

    void OnTriggerExit(Collider other)
    {
        UIElement.SetActive(false);

    }

    void OnTriggerStay(Collider other)
    {
        if (!UIElement.activeSelf)
        {
            UIElement.SetActive(true);
        }

    }
}
