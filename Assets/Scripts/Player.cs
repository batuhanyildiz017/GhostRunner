using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;  // hedef pozisyon
    public float yIncrement;    // y y�n�ndeki art��
    public float speed;         //y y�n�ndeki art�� h�z� 
    public int health;          //karakter sa�l���
    private void Start()
    {
        health = 3;
    }
    // Update is called once per frame
    void Update()
    {
        if (GameManager.gameOver==false) //oyun bitmediyse karakterin can� 0 olmad�ysa
        //playerin pozisyonunu hedef pozisyon yap�yoruz yani karakteri hareket ettirdi�imiz kod
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed* Time.deltaTime); 

    }
    /// <summary>
    /// butona t�kland���nda yukar� hareket etme
    /// </summary>
    public void Upclick() 
    {
        //-y eksenindeyse veya y=0 ise yukar� do�ru hareket et (�ift t�klamay� ve ekrandan ��kmay� engellemek i�in)
        if (transform.position.y == 0 || transform.position.y == -yIncrement) 
            targetPos = new Vector2(transform.position.x, transform.position.y + yIncrement);
    }
    /// <summary>
    /// butona t�kland���nda a�a�� hareket etme
    /// </summary>
    public void DownClick()
    {
        //+y eksenindeyse veya y=0 ise a�a�� do�ru hareket et (�ift t�klamay� ve ekrandan ��kmay� engellemek i�in)
        if (transform.position.y==0 || transform.position.y == yIncrement)
            targetPos = new Vector2(transform.position.x, transform.position.y - yIncrement);
    }
    
}
