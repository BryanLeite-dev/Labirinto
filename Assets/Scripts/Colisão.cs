using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisão : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PacMan")
        {
            Destroy(this.gameObject);
        }
    }

}
