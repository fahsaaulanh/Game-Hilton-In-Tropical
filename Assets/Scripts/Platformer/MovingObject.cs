using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{

    public Transform pos1, pos2;
    public float speed;
    public Transform startPos;
    public bool flip;
    public int move;

    Vector3 nextPos;

    void Start()
    {
        nextPos = startPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position == pos1.position)
        {
            nextPos = pos2.position;
            move = -1;
        }
        if(transform.position == pos2.position)
        {
            
            nextPos = pos1.position;
            move = 1;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);

        // cek kondisi untuk flip
        if (move > 0 && !flip)
        {
            flipObjek();
        }
        else if (move < 0 && flip)
        {
            flipObjek();

        }
    }

    private void flipObjek ()
    {
        flip = !flip;
        Vector3 karakter = transform.localScale;
        karakter.x *= -1;
        transform.localScale = karakter;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
}
