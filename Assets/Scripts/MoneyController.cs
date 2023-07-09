using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyController : MonoBehaviour
{
    [Header("Сумма собранных монет")]
    public int SumOfMoney = 0;
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Money")
            {
                SumOfMoney += 1;
                Destroy(other.gameObject);
            }
        }
}
