using UnityEngine;

public class ChargePowerUP : MonoBehaviour
{
   public int charge;

   private void OnTriggerEnter(Collider other)
   {
      charge++;
      print(charge);
   }
}
