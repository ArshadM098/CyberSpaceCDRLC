using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderHeightFix : MonoBehaviour
{
    public GameObject thisBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (thisBody.GetComponent<CapsuleCollider>().height != 2) {
            thisBody.GetComponent<CapsuleCollider>().height = 2;
        }   }
}
