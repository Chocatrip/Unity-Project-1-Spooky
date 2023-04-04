using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundCheck : MonoBehaviour
{
    public GameObject Grass;
    public GameObject Tombs;
    public GameObject Trees;
    public GameObject backTrees;
    public GameObject Sky;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag== "Grass")
        {
            GameObject a = Instantiate(Grass) as GameObject;
            a.transform.position = new Vector3(163.9f, 8.5f, 496.3326f);
        }
    }
}
