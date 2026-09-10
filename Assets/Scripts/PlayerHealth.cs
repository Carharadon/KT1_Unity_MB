using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [Header("Хп игрока")]
    [SerializeField] private int _hpPlayer = 100;

    public void DamagePlayer(int damage)
    {
        _hpPlayer -= damage;
        Debug.Log("Ловушка отняла 10 хп у игрока");
        if (_hpPlayer < 0 )
        {
            Debug.Log("Хп закончилось");
        }
    }
}