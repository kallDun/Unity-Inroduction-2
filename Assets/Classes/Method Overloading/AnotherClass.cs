using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    void Start()
    {
        OneClass myClass = new();

        myClass.Add(1, 2);
        myClass.Add("Hello ", "World");
    }
}