using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class GroundSpawner : MonoBehaviour
{
    
    // Menampung referensi grounf yang ingin di buat
    [SerializeField] private Ground groundRef;
    
    // Menampung ground sebelumnya
    private Ground prevGround;

    // Method ini akan membuat Ground game object baru
    private void SpawnGround()
    {
        // Pengecekan null variable
        if (prevGround != null)
        {
            // Menduplikasi GroundRef
            Ground newGround = Instantiate(groundRef);

            // Mengaktifkan game object
            newGround.gameObject.SetActive(true);

            // Menempatkan new ground dengan posisi nextground dari prevground agar posisinya sejajar dengan ground sebelumnya
            prevGround.SetNextGround(newGround.gameObject);
        }
    }

    // Method ini akan dipanggil ketika terdapat game object lain yang memiliki komponen colliedr keluar dari area collider
    private void OnTriggerExit2D(Collider2D collision) 
    {
        // Mencari komponent ground dari obejct yang keluar dari area trigger
        Ground ground = collision.GetComponent<Ground>();

        // Pengecekan null variable
        if (ground)
        {
            // Mengisi variable prevGround 
            prevGround = ground;

            // Membuat ground baru
            SpawnGround();
        }
    }
}
