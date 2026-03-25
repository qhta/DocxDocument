namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a mailing label.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel?view=word-pia"/>
public partial interface MailingLabel : InteropObject
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
  public WdPaperTray DefaultLaserTray { get; set; }

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
}
