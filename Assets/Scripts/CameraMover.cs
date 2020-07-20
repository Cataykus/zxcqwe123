using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _smoothness;

    private void Update()
    {
        Vector3 targetPosition = new Vector3(_target.position.x, _target.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, _smoothness * Time.deltaTime * 1000);
    }
}
