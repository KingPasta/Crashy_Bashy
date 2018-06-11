using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
    public GameObject player;
    public int coin;
    public Text coinupdate;

    void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.gameObject.tag == "Barrier")
        { movement.enabled = false;
            player.GetComponent<Rigidbody>().velocity = Vector3.zero;
            FindObjectOfType<GameManager>().EndGame();

        }

	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            coin = coin + 1;
            other.gameObject.SetActive(false);
            coinupdate.text = ("Coins: " + coin);
           // DontDestroyOnLoad(gameObject.coinupdate);
        }
    }
}
