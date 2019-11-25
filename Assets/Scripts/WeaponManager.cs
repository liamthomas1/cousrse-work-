using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    void Start()
    {
       
        ChangeWeapon(0);
    }


    public void ChangeWeapon(int index)
    {
     
         
        if (index < transform.childCount)
        {
      
            for (int i = 0; i < transform.childCount; i++)
            {
                
                if (i == index)
                {
                   
                    transform.GetChild(i).gameObject.SetActive(true);
                }
                else // DEACTIVATE ALL WEAPONS NOT AT INDEX
                {
                
                    transform.GetChild(i).gameObject.SetActive(false);
                }
            }
        }
    }


    /*
     * AddWeapon
     * adds a new weapon as a child of the WeaponManager from the "prefab" parameter
     * the new weapon will be selected when added
     */
    public void AddWeapon(GameObject prefab)
    {
        /*
         * CREATE THE NEW WEAPON FROM THE prefab PARAMETER
         * we use Instantiate to create our new weapon
         * the weapon will be in the same position and roation as the WeaponManager
         * the WeaponManager's transform will be the parent of the weapon in the Hierarchy
         * see link: https://docs.unity3d.com/ScriptReference/Object.Instantiate.html
         */
        GameObject weapon = Instantiate(prefab, transform.position, transform.rotation, transform);

        /*
         * CHANGE WEAPON TO THE NEW WEAPON
         * here, we get the current sibling index of the new weapon (where the weapon is in the Hierachy)
         * we change weapon to the current weapon's sibling index
         * NOTE: the sibling index get be obtined from its transform component
         * see link: https://docs.unity3d.com/ScriptReference/Transform.GetSiblingIndex.html
         */
        ChangeWeapon(weapon.transform.GetSiblingIndex());
    }


    /*
     * Update
     * see link: https://docs.unity3d.com/ScriptReference/MonoBehaviour.Update.html
     * we will get keyboard input to change weapons here
     * key 1 = weapon 0
     * key 2 = weapon 1
     * key 3 = weapon 2
     * see link: https://docs.unity3d.com/ScriptReference/Input.GetKeyDown.html
     * NOTE: the keyboard number keys are called "Alpha" + the keyboard number
     */
    private void Update()
    {
        /*
         * CHANGE TO WEAPON 0 WHEN KEY 1 IS PRESSED
         * when the keyboard key 1 is pressed, change to the first weapon (wepaon 0)
         */
        if (Input.GetKeyDown(KeyCode.Alpha1)) // if key 1 is pressed
        {
            ChangeWeapon(0); // change to weapon 0
        }

        /*
         * CHANGE TO WEAPON 1 WHEN KEY 2 IS PRESSED
         * when the keyboard key 2 is pressed, change to the second weapon (weapon 1)
         */
        if (Input.GetKeyDown(KeyCode.Alpha2)) // if key 2 is pressed
        {
            ChangeWeapon(1); // change to weapon 1
        }

        /*
         * CHANGE TO WEAPON 2 WHEN KEY 3 IS PRESSED
         * when the keyboard key 3 is pressed, change to the third weapon (weapon 2)
         */
        if (Input.GetKeyDown(KeyCode.Alpha3)) // if key 3 is pressed
        {
            ChangeWeapon(2); // change to weapon 2
        }
    }
}
