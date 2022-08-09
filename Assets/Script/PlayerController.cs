using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int LifePoint = 3;
    public List<GameObject> LifeIcon;
    public GameObject panelGameOver;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void subtratLifePoint()
    {
        this.LifePoint -= 1;
        Debug.Log(LifePoint);
        removeLifeIcon(LifePoint);
        if (LifePoint == 0)
        {
            panelGameOver.SetActive(true);
            Debug.Log("gameover");
        }
    }
    public void removeLifeIcon(int index)
    {
        Destroy(LifeIcon[index]);
        LifeIcon.RemoveAt(LifePoint);
        Debug.Log(index);
    }
}
