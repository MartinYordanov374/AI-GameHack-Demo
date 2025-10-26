using UnityEngine;

public class ChatBoxToggle : MonoBehaviour
{
    [Tooltip("Drag your Canvas or ChatBox GameObject here.")]
    public GameObject chatBox;

    private bool isVisible = false;

    private void Start()
    {
        if (chatBox != null)
        {
            chatBox.SetActive(false); // Hide at start
        }
    }

    private void Update()
    {
        // Press I to toggle chat box visibility
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (chatBox != null)
            {
                isVisible = !isVisible;
                chatBox.SetActive(isVisible);
            }
        }
    }
}