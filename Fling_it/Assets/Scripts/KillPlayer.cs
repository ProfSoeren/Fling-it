using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{

    public GameObject respawnMenu;
    public GameObject deadMenu;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject respawnMenuClone = (GameObject)Instantiate(respawnMenu, transform.position, Quaternion.identity);
            Destroy(respawnMenuClone, 3);
            StartCoroutine(DeadMenu());
        }
    }

    IEnumerator DeadMenu()
    {
        yield return new WaitForSeconds(3);
        deadMenu.SetActive(true);
    }
}
