using UnityEngine;

public class Flag : MonoBehaviour
{
    //private void OnTriggerEnter(Collider other)
    //{
    //    Player player = other.gameObject.GetComponent<Player>();

    //    if (player != null)
    //        return;

    //    player.Point += 10;
    //    UIMananger.instance.ShowNotiText($"+10 points\nPoints:{player.Point}");
    //    Destroy(gameObject);
    //}

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.gameObject.GetComponent<Player>();

        if (player == null)
            return;

        player.Point += 10;
        UIMananger.instance.ShowNotiText($"+10 points\nPoints:{player.Point}");
        Destroy(gameObject);
    }
}
