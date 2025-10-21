//------------------------------------------------------------
// CLASS: DetectionModule
//------------------------------------------------------------
public class DetectionModule
{
    // Continuously scans for files being downloaded.
    // If a potentially dangerous file type is detected (.exe, .msi, .bat, .scr):
    //   - Pause the download immediately.
    //   - Display the PasswordPopup for user interaction.
    //   - Receive a true/false result from the popup.
    // If result is true → resume download.
    // If result is false → cancel or delete download.
    public static void CheckForDownloads()
    {
        // Detect file download event.
        // Determine if file extension is in list of restricted types.
        // If so, pause download and call:
        //     bool allow = PasswordPopup.ShowPopup(file);
        // If allow == true → continue download.
        // If allow == false → cancel download.
        // Hint: This method represents the system’s continuous monitoring loop.
    }
}
