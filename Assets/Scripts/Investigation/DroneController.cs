using UnityEngine;

public class DroneController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float lightRange = 15f;
    public Light droneLight;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, 0, z);

        transform.Translate(
            movement * moveSpeed * Time.deltaTime
        );

        if (droneLight != null)
        {
            droneLight.range = lightRange;
        }
    }

    public void ToggleLight()
    {
        if (droneLight != null)
            droneLight.enabled = !droneLight.enabled;
    }
}