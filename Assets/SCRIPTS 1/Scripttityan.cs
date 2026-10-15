using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //int i = 0;

        //while (i < 10);
        //{
        //    i++;
        //    Debug.Log(i);
        // }
        for (int a = 10 - 1; a >= 1; a--)
        {
            Debug.Log(a);
        }

    }
}