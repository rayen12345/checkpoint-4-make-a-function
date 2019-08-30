using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ff : MonoBehaviour
{
    void sum(int a, int b, int c)
       { int x = a + b + c;
    Debug.Log(x) ;
}
    void difference(int a, int b)
    { int d = a - b;
        Debug.Log(d);
    }
    void product (int a, int b)
    { int p = a * b;
        Debug.Log(p);
    }



    void Start()
{
        sum(12, 5, 8);
        difference(10, 7);
        product(5, 9);


    }

    
}
