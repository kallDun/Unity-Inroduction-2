using UnityEngine;

public class Fruit
{
    public Fruit()
    {
        Debug.Log("1st Fruit Constructor Called");
    }
    public virtual void Chop()
    {
        Debug.Log("The fruit has been chopped.");
    }
    public virtual void SayHello()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}