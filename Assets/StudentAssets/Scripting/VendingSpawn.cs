using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VendingSpawn : MonoBehaviour
{
    public Transform Parent;
    public Transform Reference;
    public GameObject[] Items;



    public void SpawnItem(int item_number){
        GameObject x = Instantiate(Items[item_number], Reference.position, Reference.rotation, Parent);
        x.SetActive(true);
    }

}
