using UnityEngine;

public class HealthPowerUp2020 : MonoBehaviour
{
   public int health;

   private void OnTriggerEnter(Collider other)
   {
      health++;
      print(health);
   }
}
