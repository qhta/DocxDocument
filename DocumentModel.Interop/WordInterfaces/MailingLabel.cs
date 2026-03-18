namespace DocumentModel.Interop;

/// <summary>
/// Represents a mailing label.
/// </summary>
public partial interface MailingLabel : InteropObject
{
  /// <summary>
  /// The default print bar code.
  /// </summary>
  public bool DefaultPrintBarCode { get; set; }

  /// <summary>
  /// The default laser tray.
  /// </summary>
  public WdPaperTray DefaultLaserTray { get; set; }

  /// <summary>
  /// The custom labels.
  /// </summary>
  public CustomLabels CustomLabels { get; }

  /// <summary>
  /// The default label name.
  /// </summary>
  public string DefaultLabelName { get; set; }

  /// <summary>
  /// The vertical.
  /// </summary>
  public bool Vertical { get; set; }
}
