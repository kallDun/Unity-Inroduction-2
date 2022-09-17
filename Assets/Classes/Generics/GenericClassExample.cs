using UnityEngine;
using System.Collections;

public class GenericClassExample : MonoBehaviour
{
    void Start()
    {
        GenericClass<int> myClass = new();
        myClass.UpdateItem(5);
    }
}