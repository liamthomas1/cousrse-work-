using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;
[System.Serializable]
public class EnemySpawnedEvent : UnityEvent<Transform> { }
public class Enemy : MonoBehaviour
{
    public EnemySpawnedEvent onSpawn;
    private void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        //GetComponent<MoveTowardsObject>().target = player.transform;
       // GetComponent<SmoothLookAtTarget2D>().target = player.transform;
	   //what the hell this now work wait how the duck did this just ducking fix the ducking problem 07/12/2019 1:36am
        print(player);
        onSpawn.Invoke(player.transform);
    }
}

