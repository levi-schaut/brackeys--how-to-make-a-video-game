using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movementScript;
    private void OnCollisionEnter(Collision collisionInfo) 
    {
        if (collisionInfo.gameObject.tag == "Obstacle") {
            movementScript.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
