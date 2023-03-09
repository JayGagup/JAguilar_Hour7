using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int count = 0;
        while (count <= 10)
        {
            count++;
            Debug.Log(count);
        }
        count = 12;
        if(count <= 12)
        {
            Debug.Log(".My Birthday");
        }
        count = 0;
        while (count <= 19)
        {
            count++;
            Debug.Log(count);
        }
        count = 21;
        if (count<=21)
        {
            Debug.Log("MY BIRTHDAY");
        }
        count = 21;
        while(count <= 30)
        {
            count++;
            Debug.Log(count);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
