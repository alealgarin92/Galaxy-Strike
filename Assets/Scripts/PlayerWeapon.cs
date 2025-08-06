using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] GameObject[] lasers;

    bool isFiring = false;


    private void Update()
    {
        ProcessFiring();
    }
    public void OnFire(InputValue value)
    {
        isFiring = value.isPressed;
    }

    void ProcessFiring()
    {
        foreach (GameObject laser in lasers) 
        {
            var emissionModule = laser.GetComponent<ParticleSystem>().emission;
            emissionModule.enabled = isFiring;
        }
        
    }
}
