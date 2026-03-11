using UnityEngine;

public class VictoryUI : MonoBehaviour
{
    [SerializeField] private ColliderTrigger colliderTrigger;
    [SerializeField] private GameObject uiScreen;

    private void OnEnable()
    {
        colliderTrigger.OnPlayerEnters += ShowScreen;
    }

    private void OnDisable()
    {
        colliderTrigger.OnPlayerEnters -= ShowScreen;
    }

    private void Start()
    {
        uiScreen.SetActive(false);
    }
    void ShowScreen()
    {
        uiScreen.SetActive(true);
    }
}
