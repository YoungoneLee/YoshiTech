using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jankyShow : MonoBehaviour
{
    public GameObject[] fakes;
    public int counter;

    private void Start()
    {
        foreach(GameObject fake in fakes)
        {
            fake.SetActive(false);
        }
    }

    public void showItems()
    {
        if(counter < 8)
        {
            fakes[counter].SetActive(true);
            counter += 1;
        } else
        {
            Debug.Log("no more spaces");
        }
    }
}
