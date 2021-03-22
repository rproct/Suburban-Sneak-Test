using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVision : MonoBehaviour
{
    [SerializeField] private GameObject target;

    private Collider targetCol;

    [SerializeField] private Camera eyes;

    private Plane[] planes;
    // Start is called before the first frame update
    void Start()
    {
        targetCol = target.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        planes = GeometryUtility.CalculateFrustumPlanes(eyes);
        if (GeometryUtility.TestPlanesAABB(planes, targetCol.bounds))
        {
            Debug.Log("Sighted");
            CheckRacoon();
        }
    }

    void CheckRacoon()
    {
        RaycastHit hit;
        Debug.DrawRay(eyes.transform.position, transform.forward * 10, Color.green);
        if (Physics.Raycast(eyes.transform.position, transform.forward, out hit, 10))
        {
            Debug.Log("Racoon Visible");
        }
    }
}
