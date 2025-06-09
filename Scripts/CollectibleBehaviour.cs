using UnityEngine;

public class CollectibleBehaviour : MonoBehaviour
{
    int heartValue = 5;

    public void Collect(PlayerBehaviour player)
    {
        // player.ModifyScore(heartValue);
        Destroy(gameObject);
    }
}
