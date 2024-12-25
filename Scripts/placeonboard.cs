using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeonboard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Beban"))
        {
            // Pastikan beban "menempel" ke papan
            other.transform.SetParent(transform);
        }
    }
}
