namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a mailing label.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel?view=word-pia"/>
public partial interface MailingLabel : InteropObject
{
  /// <summary>
  /// The default print bar code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel.defaultprintbarcode?view=word-pia"/>
  public bool DefaultPrintBarCode { get; set; }

  /// <summary>
  /// The default laser tray.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel.defaultlasertray?view=word-pia"/>
  public WdPaperTray DefaultLaserTray { get; set; }

  /// <summary>
  /// The custom labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel.customlabels?view=word-pia"/>
  public CustomLabels CustomLabels { get; }

  /// <summary>
  /// The default label name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel.defaultlabelname?view=word-pia"/>
  public string DefaultLabelName { get; set; }

  /// <summary>
  /// The vertical.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel.vertical?view=word-pia"/>
  public bool Vertical { get; set; }
}
