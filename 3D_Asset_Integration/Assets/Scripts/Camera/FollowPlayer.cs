using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Transform target;
    private Transform cameraToBe;
    public GameObject player;

    [SerializeField] private float xOff;
    [SerializeField] private float yOff;
    [SerializeField] private float zOff;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        target = player.transform;
    }

    private void Update()
    {
        transform.position = CalculateCameraPosition();
    }

    private Vector3 CalculateCameraPosition()
    {
        Vector3 tempV3;

        tempV3.x = target.position.x + xOff;
        tempV3.y = target.position.y + yOff;
        tempV3.z = target.position.z + zOff;

        return tempV3;
    }
}
