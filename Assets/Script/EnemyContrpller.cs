using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContrpller : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position.y -= speed * Time.deltaTime;
    }
}
