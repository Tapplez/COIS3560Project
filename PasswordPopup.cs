//------------------------------------------------------------
// CLASS: PasswordPopup
//------------------------------------------------------------
public class PasswordPopup
{
    // Displays a popup window to the user when a risky file is detected.
    // Explains potential risks of continuing the download
    // (e.g., viruses, system damage, or unsafe scripts).
    //
    // Presents two options: [Proceed] or [Cancel].
    // If Cancel → return false immediately.
    //
    // If Proceed:
    //   - Prompt the user for the guardian password.
    //   - Allow up to three attempts to enter the correct password.
    //   - If correct password entered → return true.
    //   - If incorrect after three attempts → show "Download Blocked" message and return false.
    //
    // The popup stays active during the entire validation process.
    // No other class handles password checking; everything happens within this popup.
    public static bool ShowPopup(File file)
    {
        // Display popup with file name and warning.
        // Wait for user action (Proceed or Cancel).
        // If Cancel → return false.
        //
        // If Proceed:
        //     attempts = 0
        //     while attempts < 3:
        //         ask for password
        //         if password == stored guardian password → return true
        //         else show "Incorrect Password" and increment attempts
        //     end while
        //     after 3 failed attempts → return false
        //
        // Simulate popup as console text or GUI form.
    }
}
