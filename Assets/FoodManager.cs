using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{
    public GameObject[] food;
    public int currentIndex = -1;

    // Start is called before the first frame update
    void Start()
    {
        DeactivateAll();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentIndex++;
            if (currentIndex < food.Length)
            {
                DeactivateAll();
                ActivateByIndex(currentIndex);
            }
            if (currentIndex >= food.Length)
            {
                DeactivateAll();
                currentIndex = 0;
                ActivateByIndex(currentIndex);
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            DeactivateAll();
            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = food.Length - 1;
            }
            ActivateByIndex(currentIndex);

        }



    }
        void DeactivateAll()
        {
            for (int i = 0; i < food.Length; i++)
            {
                food[i].SetActive(false);
            }
        }


        void ActivateByIndex(int Index)
        {
            food[Index].SetActive(true);
        }
    
}
