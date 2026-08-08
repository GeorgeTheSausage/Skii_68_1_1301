using TMPro;
using UnityEngine;

public class UIMananger : MonoBehaviour
{
    [SerializeField]
    private TMP_Text notiText;

    [SerializeField]
    private GameObject RestartButton;

    [SerializeField]
    private Player player;

    public static UIMananger instance;

    private void Awake()
    {
        instance = this;
        RestartButton.SetActive(false);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowNotiText(string s)
    {
        notiText.text = s;
    }

    public void RestartGame()
    {
        player.transform.position= new Vector3 (-0.50f, 23.230f, -21.520f);
        player.HP = 100;
        ShowNotiText("Restart");
        Time.timeScale = 1f;
        ShowHideRestartButton(false);
    }

    public void ShowHideRestartButton(bool flag)
    {
        RestartButton.SetActive(flag);
    }
}
