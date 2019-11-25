using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

[System.Serializable]
public class OnDamagedplayerEvent : UnityEvent<int> { }
public class HealthSystem1 : MonoBehaviour
{
    public int health = 10;
    public UnityEvent onDie;
    public OnDamagedEvent onDamaged;

    public void TakeDamage (int damage )
    {
        health -= damage;
        onDamaged.Invoke(health);
        if( health <1)
        {
            onDie.Invoke();
            Destroy(gameObject);
			SceneManager.LoadScene("Game Over");


		}
    }
}