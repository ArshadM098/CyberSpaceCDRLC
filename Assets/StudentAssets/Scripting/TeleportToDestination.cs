using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToDestination : MonoBehaviour
{
    public GameObject AreaTarget;
    public GameObject HeadsetTarget;
    public int Destination_Index = 0;
    public Vector3 offset = new Vector3(0, 1.5f, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void InitiateTP() {
        Vector3 temp = AreaTarget.transform.position - HeadsetTarget.transform.position;
        temp.y = this.transform.position.y;
        AreaTarget.transform.position = this.transform.position + temp +offset;
        HeadsetTarget.transform.position = this.transform.position + offset;
    }
}
