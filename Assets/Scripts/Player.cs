using UnityEngine.Advertisements;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject restart;
    public static bool lose = false;

    void Awake()
    {
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize("3945117", false);
        }
        lose = false;
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "Bomb")
        {
            if (Advertisement.IsReady())
            {
                Advertisement.Show("video");
            }
            lose = true;
            restart.SetActive(true);
        }
    }
}
