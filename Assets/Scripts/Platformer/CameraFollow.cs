using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public float jarak;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 pos = new Vector3(player.transform.localPosition.x + (player.transform.localScale.x * jarak), 0, -100f);
        transform.localPosition = Vector3.Slerp(transform.localPosition, pos, 0.1f);
    }
}
