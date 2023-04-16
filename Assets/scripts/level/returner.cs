using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class returner : MonoBehaviour
{
    [SerializeField] PlayerMovement player;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
           
            GameManager.Instance.nextLevel();

        }
    }


}
