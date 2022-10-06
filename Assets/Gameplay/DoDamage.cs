using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI

public class DoDamage : MonoBehaviour
{



    [SerializeField] private int _damage = 10;
    private void OnTriggerEnter(Collider other)//on trigger enter, es cuando entra en contacto, y entonces empieza a contar
    {
        
        //:este te deja aplicarlo a otros enemigos

        if (other.GetComponent<Health>() != null) {

            other.GetComponent<Health>().ReceiveDamage(10); //si no se nula la existencia del objeto, entonces extrae la variente health, y enciende el Receive damage


        }
        
    }
}
