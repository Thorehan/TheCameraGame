using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouseLook : MonoBehaviour
{
    public Camera cam;
    
    private float xRotation = 0f;

    public float xSensitivity = 30f;
    public float ySensitivity = 30f;

    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;
        //kamera rotasyonu hesaplama
        xRotation -= (mouseY * Time.deltaTime) * ySensitivity;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        // camera transforma uygula
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        // saða sola bakarken karakteri çevir
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity);
    }


}
