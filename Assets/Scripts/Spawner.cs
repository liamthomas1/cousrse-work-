using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabTOSpawn;
    public float adjustmentAngle = 0;

    public void Spawn()
    {
        Vector3 rotationInDegree = transform.eulerAngles;
        rotationInDegree.z += adjustmentAngle;
        Quaternion rotationInRadians = Quaternion.Euler(rotationInDegree);
        Instantiate(prefabTOSpawn, transform.position, rotationInRadians);
    }









}

