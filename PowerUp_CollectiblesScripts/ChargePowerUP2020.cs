using UnityEngine;

public class ChargePowerUP2020 : MonoBehaviour
{
   public int charge;

   private void OnTriggerEnter(Collider other)
   {
      charge++;
      print(charge);
   }
}
