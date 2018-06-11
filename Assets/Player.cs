using UnityEngine;

public class Player : MonoBehaviour
{

    public class PlayerStats {
        public int Health = 3;    
    }

    public PlayerStats playerStats = new PlayerStats();
   
    public void DamagePlayer(int damage) {
        playerStats.Health -= damage;
        if (playerStats.Health <= 0) {
            Debug.Log("Kill Player");
        }
    }

}