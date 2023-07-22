using UnityEngine;

public class NoteTaker : MonoBehaviour
{
    [TextArea(3, 10)] // Adjust the number of rows (3) and maximum number of rows (10) as per your preference
    public string notes;

    // Update is called once per frame
    void Update()
    {
        // Check for input to save the notes
        if (Input.GetKeyDown(KeyCode.S) && Input.GetKey(KeyCode.LeftControl))
        {
            SaveNotes();
        }
    }

    void SaveNotes()
    {
        // Save the notes to a file or perform any desired action
        Debug.Log("Notes saved: " + notes);
    }
}