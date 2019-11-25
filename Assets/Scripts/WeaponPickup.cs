using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup : MonoBehaviour
{
    public GameObject weaponPrefab;


    /*
     * OnTriggerEnter2D
     * see link: https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnTriggerEnter2D.html
     * we get the WeaponManager component from the player
     * we then add the weapon prefab using the WeaponManager's AddWeapon method
     * finally, we destroy this pickup, as it has been picked up!
     */
    private void OnTriggerEnter2D(Collider2D other)
    {
        /*
         * GET THE PLAYERS WeaponManager COMPONENT
         * we get the WeaponManager using GetComponentInChildren, this will search for the WeaponManager
         * component in all of the player GameObject's children GameObjects
         * see link: https://docs.unity3d.com/ScriptReference/Component.GetComponentInChildren.html
         */
        WeaponManager weaponManager = other.gameObject.GetComponentInChildren<WeaponManager>();


        /*
         * if we found a WeaponManager component, we can add the weapon
         */
        if (weaponManager != null) // if we found a WeaponManager component
        {
            /*
             * ADD THE NEW WEAPON TO THE PLAYER'S WeaponManager COMPONENT
             * call the AddWeapon method on the WeaponManager and give it the weapon prefab
             */
            weaponManager.AddWeapon(weaponPrefab);


            /*
             * DESTROY THE WEAPON PICKUP GAMEOBJECT
             * see link: https://docs.unity3d.com/ScriptReference/Object.Destroy.html
             * here we destroy the weapon pickup GameObject so the player can't pick it up again
             */
            Destroy(gameObject);
        }
    }
}


