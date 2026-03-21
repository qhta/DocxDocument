namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the mail merge functionality in Microsoft Word.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge?view=word-pia"/>
public partial interface MailMerge : InteropObject
{
  /// <summary>
  /// The main document type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.maindocumenttype?view=word-pia"/>
  public WdMailMergeMainDocType MainDocumentType { get; set; }

  /// <summary>
  /// The state.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.state?view=word-pia"/>
  public WdMailMergeState State { get; }

  /// <summary>
  /// The destination.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.destination?view=word-pia"/>
  public WdMailMergeDestination Destination { get; set; }

  /// <summary>
  /// The data source.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.datasource?view=word-pia"/>
  public MailMergeDataSource DataSource { get; }

  /// <summary>
  /// The fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.fields?view=word-pia"/>
  public MailMergeFields Fields { get; }

  /// <summary>
  /// The view mail merge field codes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.viewmailmergefieldcodes?view=word-pia"/>
  public int ViewMailMergeFieldCodes { get; set; }

  /// <summary>
  /// The suppress blank lines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.suppressblanklines?view=word-pia"/>
  public bool SuppressBlankLines { get; set; }

  /// <summary>
  /// The mail as attachment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.mailasattachment?view=word-pia"/>
  public bool MailAsAttachment { get; set; }

  /// <summary>
  /// The mail address field name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.mailaddressfieldname?view=word-pia"/>
  public string MailAddressFieldName { get; set; }

  /// <summary>
  /// The mail subject.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.mailsubject?view=word-pia"/>
  public string MailSubject { get; set; }

  /// <summary>
  /// The highlight merge fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.highlightmergefields?view=word-pia"/>
  public bool HighlightMergeFields { get; set; }

  /// <summary>
  /// The mail format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.mailformat?view=word-pia"/>
  public WdMailMergeMailFormat MailFormat { get; set; }

  /// <summary>
  /// The show send to custom.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.showsendtocustom?view=word-pia"/>
  public string ShowSendToCustom { get; set; }

  /// <summary>
  /// The wizard state.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.wizardstate?view=word-pia"/>
  public int WizardState { get; set; }
}
