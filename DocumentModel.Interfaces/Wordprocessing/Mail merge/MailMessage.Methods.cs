namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmessage?view=word-pia"/>
public partial interface IMailMessage: IModelObject
{
  /// <summary>
  /// Validates the e-mail addresses that appear in the To:, Cc:, and Bcc: lines in the active e-mail message. This
  /// method is available only if you are using Microsoft Word as your e-mail editor.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmessage.checkname?view=word-pia"/>
  public void CheckName();

  /// <summary>
  /// Deletes the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmessage.delete?view=word-pia"/>
  public void Delete();

  /// <summary>
  /// Displays the Move dialog box, in which the user can specify a new location for the active e-mail message in an
  /// available message store. This method is available only if you are using Microsoft Word as your e-mail editor.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmessage.displaymovedialog?view=word-pia"/>
  public void DisplayMoveDialog();

  /// <summary>
  /// Displays the Properties dialog box for the active e-mail message. This method is available only if you are
  /// using Microsoft Word as your e-mail editor.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmessage.displayproperties?view=word-pia"/>
  public void DisplayProperties();

  /// <summary>
  /// Displays the Select Names dialog box, in which the user can add addresses to the To:, Cc:, and Bcc: lines in
  /// the active, unsent e-mail message. This method is available only if you are using Microsoft Word as your
  /// e-mail editor.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmessage.displayselectnamesdialog?view=word-pia"/>
  public void DisplaySelectNamesDialog();

  /// <summary>
  /// Opens a new e-mail message with an empty To: line for forwarding the active message. This method is available
  /// only if you are using Microsoft Word as your e-mail editor.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmessage.forward?view=word-pia"/>
  public void Forward();

  /// <summary>
  /// Displays the next mail message if you are using Microsoft Word as your e-mail editor.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmessage.gotonext?view=word-pia"/>
  public void GoToNext();

  /// <summary>
  /// Displays the previous mail message if you are using Microsoft Word as your e-mail editor.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmessage.gotoprevious?view=word-pia"/>
  public void GoToPrevious();

  /// <summary>
  /// Opens a new e-mail message— with the sender's address on the To: line— for replying to the active message.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmessage.reply?view=word-pia"/>
  public void Reply();

  /// <summary>
  /// Opens a new e-mail message— with the sender’s and all other recipients' addresses on the To: and Cc: lines, as
  /// appropriate— for replying to the active message.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmessage.replyall?view=word-pia"/>
  public void ReplyAll();

  /// <summary>
  /// Toggles the display of the header in the active e-mail message.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmessage.toggleheader?view=word-pia"/>
  public void ToggleHeader();
}
