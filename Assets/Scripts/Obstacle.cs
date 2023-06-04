using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int damage = 1;
    public float speed;
    
    // Start is called before the first frame update
    private void Update()
    {
        if (GameManager.gameOver==false)  //oyun bitmediyse karakterin can� 0 olmad�ysa
            transform.Translate(Vector2.left * speed * Time.deltaTime); // engelin sola do�ru gitmesi
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<Player>().health -= damage; //oyuncunun can� damage ile azal�r
            Debug.Log(collision.GetComponent<Player>().health);
            Destroy(gameObject); //engel yok edilir
        }
    }

}
