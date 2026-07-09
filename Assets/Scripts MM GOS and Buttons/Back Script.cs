using UnityEngine;

public class BackScript : MonoBehaviour
{
    public GameObject MainMenuPanel;
    public GameObject SaveSlotPanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackToMenu()
    {
        MainMenuPanel.SetActive(false);
        SaveSlotPanel.SetActive(true);
    }
}
