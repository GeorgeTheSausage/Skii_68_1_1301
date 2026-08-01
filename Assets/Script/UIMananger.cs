using TMPro;
using UnityEngine;

public class UIMananger : MonoBehaviour
{
    [SerializeField]
    private TMP_Text notiText;
    public static UIMananger instance;

    private void Awake()
    {
        instance = this;
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
}
