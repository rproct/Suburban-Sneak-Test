using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Run"))
            Move(3);
        else
            Move(1);
    }

    void Move(float speed)
    {
        float hori = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float veri = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(hori, 0, veri);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("trash") && Input.GetButton("Collect")) 
            Destroy(other.gameObject);

    }
}
