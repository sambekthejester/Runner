using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    [SerializeField] PlayerMovement player;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            player.enabled = false;
            GameManager.Instance.GameOver();
            Debug.Log("gameover");
        }
    }
}
