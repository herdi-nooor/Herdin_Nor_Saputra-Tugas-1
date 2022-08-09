using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanController : MonoBehaviour
{
    public Vector2 Speed;
    public float Forward;
    public Rigidbody2D Human;
    public SpawnController spawnManager;
    public PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        Human = GetComponent<Rigidbody2D>();
        Human.velocity = Speed;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.GetComponent<Rigidbody2D>().name == "Walldestroyer")
        {
            spawnManager.removeEnemy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        spawnManager.removeEnemy(gameObject);
        player.subtratLifePoint();

    }
}
