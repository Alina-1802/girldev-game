using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    GameObject weapon;
    private void SpawnWeapon(GameObject weaponPrefab)
    {
        Vector3 spawnPosition = transform.position;
        weapon = Instantiate(weaponPrefab, spawnPosition, weaponPrefab.transform.rotation, transform);
        weapon.transform.localPosition = new Vector3(0.653999984f, 0.714999974f, 0f);
    }

    private void ThrowWeapon()
    {
        if (weapon != null)
        {
            Rigidbody weaponRigidbody = weapon.GetComponent<Rigidbody>();
            Vector3 force = new Vector3(0, 0, 30f);
            Vector3 torque = new Vector3(-100f, 0, 100f);
            weaponRigidbody.AddForce(force, ForceMode.Impulse);
            weaponRigidbody.AddTorque(torque, ForceMode.Impulse);
        }
    }

    public void Shoot(GameObject weaponPrefab)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnWeapon(weaponPrefab);
            ThrowWeapon();
        }
    }
}
