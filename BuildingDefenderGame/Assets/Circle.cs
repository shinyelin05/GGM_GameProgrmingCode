using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Circle : MonoBehaviour
{
    private GameObject enemyObject;

    private void Update()
    {
        enemyObject = GameObject.Find("pfEnemy(Clone)");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (enemyObject != null)
        {
            enemyObject.GetComponent<Enemy>().DesDestroy();
        }
     
    }
}
