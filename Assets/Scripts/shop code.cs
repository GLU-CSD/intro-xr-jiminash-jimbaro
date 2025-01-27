using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class shopcode : MonoBehaviour
{

    public GameObject Shopitem1;       // Het object dat je wilt spawnen

    public GameObject Shopitem2;       // Het object dat je wilt spawnen

    public GameObject Shopitem3;       // Het object dat je wilt spawnen

    public GameObject Shopitem4;       // Het object dat je wilt spawnen


    public void buyitem1()
    {
        if (Shopitem1 != null)
        {
            Instantiate(Shopitem1, transform.position, transform.rotation);
        }
    }
    public void buyitem2()
    {
        if (Shopitem2 != null)
        {
            Instantiate(Shopitem1, transform.position, transform.rotation);
        }
    }
    public void buyitem3()
    {
        if (Shopitem3 != null)
        {
            Instantiate(Shopitem1, transform.position, transform.rotation);
        }
    }
    public void buyitem4()
    {
        if (Shopitem4 != null)
        {
            Instantiate(Shopitem1, transform.position, transform.rotation);
        }
    }
}
