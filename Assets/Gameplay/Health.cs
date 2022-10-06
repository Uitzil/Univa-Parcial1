using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{

    [SerializeField] private int _health = 100; 

    private int _currenthealth = 100; //estos dos le dan un valor de vida inicial al objeto
    private UnityEvent<float> _onHealthChanged = new (); //este es la variante del cambio
    

    void OnEnable()
    {
        _currenthealth = _health; //aqui mide la vida actual

    }

    public void ReceiveDamage(int damage) //creamos la situacion del golpe y la variable del daño
    {
        if (_currenthealth < 0) ;
        {
            _currenthealth = 0;
        }
        _currenthealth -= damage; //si se activa este void, entonces se le resta, es decir: [(-=) x=x-y ], la variable de damage a la vida actual
        _onHealthChanged?.Invoke((float)_currenthealth / _health);
        if (_currenthealth == 0)
            _onDeath?.Invoke();
                }
    

}

