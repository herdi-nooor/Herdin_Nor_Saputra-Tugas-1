using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContrpller : MonoBehaviour
{
    public Vector2 Speed;
    public float Forward;
    public Rigidbody2D Enemy;
    // Start is called before the first frame update
    void Start()
    {
        Enemy = GetComponent<Rigidbody2D>();
        Enemy.velocity = Speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -6.0f)
        {
            Debug.Log("destroy");
            Destroy(Enemy);
        }
    }




}
