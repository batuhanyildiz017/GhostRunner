using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacle : MonoBehaviour
{
    public float sure; // Ba�lang�� s�resi
    private float gecenSure; // Ge�en s�reyi tutmak i�in de�i�ken
    private bool zamanDoldu; // Zaman�n doldu�unu kontrol etmek i�in de�i�ken    

    private void Start()
    {
        gecenSure = sure;
        zamanDoldu = false;
    }

    private void Update()
    {
        if (!zamanDoldu)
        {
            // Zaman� azalt
            gecenSure -= Time.deltaTime;

            // Zaman� kontrol et
            if (gecenSure <= 0f)
            {
                gecenSure = 0f;
                zamanDoldu = true;
                ZamanDoldu();
            }

            
        }
    }

    private void ZamanDoldu()
    {
        Destroy(gameObject);  // obstacle objesini ve obstacle pattern objelerini yok ediyor.
        
    }

}
