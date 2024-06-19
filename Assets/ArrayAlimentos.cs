using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayAlimentos : MonoBehaviour
{

    public GameObject objetos;
    public GameObject[] Alimentos;
    public int currentindex;

    // Start is called before the first frame update
    void Start()
    {
        DeactivateAll();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (currentindex == 0)
            {
                currentindex = 14;
            }
            else
            {
                currentindex -= 1;
            }
            Retroceder();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentindex == 14)
            {
                currentindex = 0;
            }
            else
            {
                currentindex += 1;
            }
            Continuar();
        }
    }

    public void DeactivateAll()
    {
        for (int i = 0; i < Alimentos.Length; i++)
        {
            Alimentos[i].SetActive(false);
        }

    }

    public void Retroceder()
    {
        DeactivateAll();
        Alimentos[currentindex].SetActive(true);
    }

    public void Continuar()
    {
        DeactivateAll();
        Alimentos[currentindex].SetActive(true);
    }

}
