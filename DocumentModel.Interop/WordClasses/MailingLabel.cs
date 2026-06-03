namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a mailing label.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel?view=word-pia"/>
public partial class MailingLabel : InteropObject
{
  /// <summary>
  /// Returns or sets whether a bar code is printed by default on mailing labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel.defaultprintbarcode?view=word-pia"/>
  public bool DefaultPrintBarCode { get; set; }

  /// <summary>
  /// Returns or sets the default printer tray used for laser labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel.defaultlasertray?view=word-pia"/>
  public PaperTray DefaultLaserTray { get; set; }

  /// <summary>
  /// Returns the custom labels collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel.customlabels?view=word-pia"/>
  public CustomLabels CustomLabels { get; set; }

  /// <summary>
  /// Returns or sets the default mailing label name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel.defaultlabelname?view=word-pia"/>
  public string? DefaultLabelName { get; set; }

  /// <summary>
  /// Returns or sets whether labels are printed vertically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel.vertical?view=word-pia"/>
  public bool Vertical { get; set; }


  #region methods

/// <summary>
  /// Creates a new mailing labels document using Word 2000-compatible behavior.
  /// </summary>
  /// <param name="name">Specifies the mailing label type name.</param>
  /// <param name="address">Specifies the mailing address text.</param>
  /// <param name="autoText">Specifies an AutoText entry for the label content.</param>
  /// <param name="extractAddress">Specifies whether to extract the address from the active document.</param>
  /// <param name="laserTray">Specifies the laser printer tray.</param>
  /// <returns>The created mailing labels document.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel.createnewdocument2000?view=word-pia"/>
  public Document CreateNewDocument2000(string name, string address, string autoText, bool extractAddress, int laserTray) { throw new NotImplementedException(); }

  #endregion methods
}
