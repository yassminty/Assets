using UnityEngine;
using TMPro;


public class CollectibleBehaviour : MonoBehaviour
{
    private int heartValue = 5; //so amount cant be changed externally

    public TextMeshProUGUI Score; //using tmpro for ui stuff

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Heart")
        {
            heartValue += 5; //increases score of player
            Score.text = "Score: " + heartValue.ToString(); //updates score for player after they interact with the items
            Debug.Log(heartValue); //just to write out in console if it works lol
            Destroy(other.gameObject); //collectible willbe destroyed after user is done interacting with it

        }
    }
}