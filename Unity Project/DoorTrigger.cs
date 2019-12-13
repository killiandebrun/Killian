using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject door;

    bool IsOpened = false;

    void OnTriggerEnter(Collider col)
    {
        if(!IsOpened)
        {
            IsOpened = true;
            door.transform.position += new Vector3(0, 4, 0);
        }
     
    }
}
