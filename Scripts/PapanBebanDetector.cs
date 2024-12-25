using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PapanBebanDetector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Pastikan objek yang masuk trigger memiliki tag "Beban"
        if (other.CompareTag("Beban"))
        {
            other.transform.SetParent(transform);
            Debug.Log("Beban terdeteksi di papan: " + other.gameObject.name);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Tambahkan log jika beban keluar dari area trigger
        if (other.CompareTag("Beban"))
        {
            other.transform.SetParent(transform);
            Debug.Log("Beban keluar dari papan: " + other.gameObject.name);
        }
    }
}
