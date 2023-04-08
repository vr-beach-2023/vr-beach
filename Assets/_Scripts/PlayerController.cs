using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Vector2 playerVelocity;
    [SerializeField] private float playerSpeed = 10f;
    [SerializeField] private float playerRotate = 20f;

    void Update()
    {
#if UNITY_EDITOR
        /// forward and backward
        if (Input.GetKey(KeyCode.W)) rb.velocity = transform.forward * playerSpeed;
        if (Input.GetKey(KeyCode.S)) rb.velocity = -transform.forward * playerSpeed;

        /// rotation
        if (Input.GetKey(KeyCode.D)) transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * playerRotate, Space.World);
        if (Input.GetKey(KeyCode.A)) transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * playerRotate, Space.World);
#endif
    }
}