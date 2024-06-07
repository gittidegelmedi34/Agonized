using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using UnityEngine.Tilemaps;

public class PillTaking : MonoBehaviour
{   
    public GameObject Player;
    public Vector3 scale = new Vector3(0.5f,0.5f,1);



    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (gameObject.tag == "blue-pill")
        {
            Player.transform.localScale = scale;

            Destroy(gameObject);



        }
    }


}
