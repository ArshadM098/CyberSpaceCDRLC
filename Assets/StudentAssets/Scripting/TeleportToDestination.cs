using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToDestination : MonoBehaviour
{
    public GameObject PlayerTarget;
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
        PlayerTarget.transform.position = this.transform.position + offset;
    }
}