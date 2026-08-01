using UnityEngine;

public class Tree : MonoBehaviour
{
    private MeshRenderer rd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rd = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        rd.material.color = Color.red;
        Player player = collision.gameObject.GetComponent<Player>();

        //Debug.Log(player);
        if (player == null)
        {
            return;
        }

        player.HP -= 15;
        UIMananger.instance.ShowNotiText($"Ouch -15\nHP: {player.HP}");

    }

    private void OnCollisionExit(Collision collision)
    {
        rd.material.color = new Color32(130,80,61,255);
    }
}
