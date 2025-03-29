using UnityEngine;

public class HitToRespawn : MonoBehaviour
{
    public GameObject player;
    public Transform respawnPoint;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.transform.position = respawnPoint.position;
        }
    }
}
