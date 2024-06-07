using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Updater : MonoBehaviour
{
    public bool collided = false;

    public GameObject player;
    public float restoreTime; 

    public void Restore()
    {
        player.transform.localScale = new Vector3(1,1,1);
    }
    public void Update()
    {
        if(collided)
        {
            Invoke("Restore", 1f);
            collided = false;
        }
    }
}
