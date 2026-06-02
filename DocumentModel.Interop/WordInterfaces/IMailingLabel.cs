namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a mailing label.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel?view=word-pia"/>
public partial interface IMailingLabel : IInteropObject
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
  public CustomLabels CustomLabels { get; }

  /// <summary>
  /// Returns or sets the default mailing label name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel.defaultlabelname?view=word-pia"/>
  public string DefaultLabelName { get; set; }

  /// <summary>
  /// Returns or sets whether labels are printed vertically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel.vertical?view=word-pia"/>
  public bool Vertical { get; set; }


  #region methods

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

  #endregion methods
}
