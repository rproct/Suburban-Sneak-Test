using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempEnemyScript : MonoBehaviour
{
    public float speed;
    void Update()
    {
        float rot = speed * Time.deltaTime;
        transform.Rotate(0, rot, 0);
        
    }
}
