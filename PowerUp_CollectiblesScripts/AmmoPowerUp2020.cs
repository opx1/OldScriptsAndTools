using System;
using UnityEngine;

public class AmmoPowerUp2020 : MonoBehaviour
{
 public int ammo;

 private void OnTriggerEnter(Collider other)
 {
  ammo++;
print(ammo);
 }
}
