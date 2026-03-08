using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGeneration : MonoBehaviour
{

    [SerializeField] Transform BasketsHolder;


    private void OnTriggerEnter2D(Collider2D collision)
    {           
        if (collision.CompareTag("Basket") && collision.transform.GetSiblingIndex() == 2)
        {
            BasketsHolder.GetChild(0).transform.position = BasketsHolder.GetChild(BasketsHolder.childCount - 1).transform.position 
                                                            + new Vector3(5, 0, 0);

            BasketsHolder.GetChild(0).SetSiblingIndex(BasketsHolder.childCount - 1);
        }

    }


}
