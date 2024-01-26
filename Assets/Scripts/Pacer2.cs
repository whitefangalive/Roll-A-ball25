using System.Collections;
using UnityEngine;

public class Pacer2 : MonoBehaviour
{
    public float speed = 5.0f;
    private float zMax = 7.5f;
    private float zMin = -7.5f; //starting position
    private int direction = 1; //positive to start

    private float xMax = 7.5f;
    private float xMin = -7.5f;
    private int directionX = 1;

    void Update()
    {
        float zNew = transform.position.z +
        direction * speed * Time.deltaTime;
        if (zNew >= zMax)
        {
            zNew = zMax;
            direction *= -1;
        }
        else if (zNew <= zMin)
        {
            zNew = zMin;
            direction *= -1;
        }
        transform.position = new Vector3(transform.position.x, transform.position.y, zNew);

        float xNew = transform.position.x +
        directionX * speed * Time.deltaTime;
        if (xNew >= xMax)
        {
            xNew = xMax;
            directionX *= -1;
        }
        else if (xNew <= xMin)
        {
            xNew = xMin;
            directionX *= -1;
        }
        transform.position = new Vector3(xNew, transform.position.y, transform.position.z);
    }
}