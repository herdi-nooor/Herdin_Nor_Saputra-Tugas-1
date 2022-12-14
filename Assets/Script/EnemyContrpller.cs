using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContrpller : MonoBehaviour
{
    public Vector2 Speed;
    public float Forward;
    public Rigidbody2D Enemy;
    public SpawnController spawnManager;
    public PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        Enemy = GetComponent<Rigidbody2D>();
        Enemy.velocity = Speed;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.GetComponent<Rigidbody2D>().name == "Walldestroyer")
        {
            player.subtratLifePoint();
            spawnManager.removeEnemy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        spawnManager.removeEnemy(gameObject);
    }

}
