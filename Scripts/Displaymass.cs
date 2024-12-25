using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Displaymass : MonoBehaviour
{
    public Rigidbody2D rb; // Hubungkan Rigidbody 2D
    public TextMeshProUGUI massText; // Hubungkan komponen teks

    void Start()
    {
        // Pastikan Rigidbody 2D terhubung
        if (rb == null)
        {
            rb = GetComponent<Rigidbody2D>();
            if (rb == null)
            {
                Debug.LogError("Rigidbody2D is missing from the object!");
                return; // Keluar jika tidak ada Rigidbody2D
            }
        }

        // Mengatur gravity scale menjadi 0 untuk mencegah jatuh
        rb.gravityScale = 0;

        // Menampilkan massa pada teks
        if (massText == null)
        {
            Debug.LogError("Mass text reference is missing!");
        }
        else
        {
            massText.text = $"{rb.mass} kg"; // Menampilkan massa di UI
        }
    }
}
