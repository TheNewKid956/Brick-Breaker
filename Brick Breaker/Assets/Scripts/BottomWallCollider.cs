using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomWallCollider : MonoBehaviour
{
    public LevelManager levelManager;

    public void OnCollisionEnter(Collision collision)
    {
        levelManager.loadLevel("lose");
    }
}
