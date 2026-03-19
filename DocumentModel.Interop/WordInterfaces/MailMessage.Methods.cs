namespace DocumentModel.Interop.Word;

public partial interface MailMessage
{
  /// <summary>
  /// Validates the e-mail addresses that appear in the To:, Cc:, and Bcc: lines in the active e-mail message. This method is available only if you are using Microsoft Word as your e-mail editor.
  /// </summary>
  public void CheckName();

  /// <summary>
  /// Deletes the specified object.
  /// </summary>
  public void Delete();

  /// <summary>
  /// Displays the Move dialog box, in which the user can specify a new location for the active e-mail message in an available message store. This method is available only if you are using Microsoft Word as your e-mail editor.
  /// </summary>
  public void DisplayMoveDialog();

  /// <summary>
  /// Displays the Properties dialog box for the active e-mail message. This method is available only if you are using Microsoft Word as your e-mail editor.
  /// </summary>
  public void DisplayProperties();

  /// <summary>
  /// Displays the Select Names dialog box, in which the user can add addresses to the To:, Cc:, and Bcc: lines in the active, unsent e-mail message. This method is available only if you are using Microsoft Word as your e-mail editor.
  /// </summary>
  public void DisplaySelectNamesDialog();

  /// <summary>
  /// Opens a new e-mail message with an empty To: line for forwarding the active message. This method is available only if you are using Microsoft Word as your e-mail editor.
  /// </summary>
  public void Forward();

  /// <summary>
  /// Displays the next mail message if you are using Microsoft Word as your e-mail editor.
  /// </summary>
  public void GoToNext();

  /// <summary>
  /// Displays the previous mail message if you are using Microsoft Word as your e-mail editor.
  /// </summary>
  public void GoToPrevious();

  /// <summary>
  /// Opens a new e-mail messageâ?? with the sender's address on the To: lineâ?? for replying to the active message.
  /// </summary>
  public void Reply();

  /// <summary>
  /// Opens a new e-mail messageâ?? with the senderâ??s and all other recipients' addresses on the To: and Cc: lines, as appropriateâ?? for replying to the active message.
  /// </summary>
  public void ReplyAll();

  /// <summary>
  /// Toggles the display of the header in the active e-mail message.
  /// </summary>
  public void ToggleHeader();
}
