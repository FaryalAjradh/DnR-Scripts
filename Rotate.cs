using System.Collections;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, 170f) * Time.deltaTime);
    }
}
