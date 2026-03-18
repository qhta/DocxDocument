namespace DocumentModel.Interop;

/// <summary>
/// Represents the mail merge functionality in Microsoft Word.
/// </summary>
public partial interface MailMerge : InteropObject
{
  /// <summary>
  /// The main document type.
  /// </summary>
  public WdMailMergeMainDocType MainDocumentType { get; set; }

  /// <summary>
  /// The state.
  /// </summary>
  public WdMailMergeState State { get; }

  /// <summary>
  /// The destination.
  /// </summary>
  public WdMailMergeDestination Destination { get; set; }

  /// <summary>
  /// The data source.
  /// </summary>
  public MailMergeDataSource DataSource { get; }

  /// <summary>
  /// The fields.
  /// </summary>
  public MailMergeFields Fields { get; }

  /// <summary>
  /// The view mail merge field codes.
  /// </summary>
  public int ViewMailMergeFieldCodes { get; set; }

  /// <summary>
  /// The suppress blank lines.
  /// </summary>
  public bool SuppressBlankLines { get; set; }

  /// <summary>
  /// The mail as attachment.
  /// </summary>
  public bool MailAsAttachment { get; set; }

  /// <summary>
  /// The mail address field name.
  /// </summary>
  public string MailAddressFieldName { get; set; }

  /// <summary>
  /// The mail subject.
  /// </summary>
  public string MailSubject { get; set; }

  /// <summary>
  /// The highlight merge fields.
  /// </summary>
  public bool HighlightMergeFields { get; set; }

  /// <summary>
  /// The mail format.
  /// </summary>
  public WdMailMergeMailFormat MailFormat { get; set; }

  /// <summary>
  /// The show send to custom.
  /// </summary>
  public string ShowSendToCustom { get; set; }

  /// <summary>
  /// The wizard state.
  /// </summary>
  public int WizardState { get; set; }
}
