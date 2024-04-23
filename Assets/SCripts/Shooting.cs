using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shooting : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bulletPrefab;

    private void Update()
    {
        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);

        }
    }
}
