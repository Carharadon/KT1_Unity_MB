using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Trap : MonoBehaviour
{
    [Header("Настройка урона")]
    [SerializeField] private int _damageTrap = 10;


    [Header("Ссылка на HP")]
    [SerializeField] private TextMeshPro _healthText;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerHealth>().DamagePlayer(_damageTrap);
            Debug.Log("Ловушка сработала" + _damageTrap);
        }
    }
}
