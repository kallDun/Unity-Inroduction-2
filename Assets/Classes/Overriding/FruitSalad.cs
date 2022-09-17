using UnityEngine;

public class FruitSalad : MonoBehaviour
{
    void Start()
    {
        Apple myApple = new();

        myApple.SayHello();
        myApple.Chop();

        Fruit myFruit = new Apple();
        myFruit.SayHello();
        myFruit.Chop();
    }
}