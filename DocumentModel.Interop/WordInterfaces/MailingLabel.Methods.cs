namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel?view=word-pia"/>
public partial interface IMailingLabel
{
  /// <summary>
  /// Creates a new mailing labels document using Word 2000-compatible behavior.
  /// </summary>
  /// <param name="Name">Specifies the mailing label type name.</param>
  /// <param name="Address">Specifies the mailing address text.</param>
  /// <param name="AutoText">Specifies an AutoText entry for the label content.</param>
  /// <param name="ExtractAddress">Specifies whether to extract the address from the active document.</param>
  /// <param name="LaserTray">Specifies the laser printer tray.</param>
  /// <returns>The created mailing labels document.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel.createnewdocument2000?view=word-pia"/>
  public Document CreateNewDocument2000(string Name, string Address, string AutoText, bool ExtractAddress, int LaserTray);
}
