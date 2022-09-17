using UnityEngine;

public class Avatar : MonoBehaviour, IKillable, IDamageable<float>
{
    public void Kill()
    {
        Debug.Log("Kill message");
    }

    public void Damage(float damageTaken)
    {
        Debug.Log("Damage message");
    }
}