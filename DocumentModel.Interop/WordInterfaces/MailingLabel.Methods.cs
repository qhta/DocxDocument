namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel?view=word-pia"/>
public partial interface MailingLabel
{
  /// <summary>
  /// Creates a new document for mailing labels using Word 2000 compatibility.
  /// </summary>
  /// <param name="Name">The name of the mailing label type.</param>
  /// <param name="Address">The address to use on the label.</param>
  /// <param name="AutoText">The AutoText entry to use for the label.</param>
  /// <param name="ExtractAddress">true to extract the address from the document; otherwise, false.</param>
  /// <param name="LaserTray">The tray to use for laser printing.</param>
  /// <returns>The created <see cref="Document"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel.createnewdocument2000?view=word-pia"/>
  public Document CreateNewDocument2000(string Name, string Address, string AutoText, bool ExtractAddress, int LaserTray);
}
