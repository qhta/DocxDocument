namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the mail merge functionality in Microsoft Word.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge?view=word-pia"/>
public partial interface MailMerge : InteropObject
{
  /// <summary>
  /// Returns or sets the main document type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.maindocumenttype?view=word-pia"/>
  public WdMailMergeMainDocType MainDocumentType { get; set; }

  /// <summary>
  /// Returns the state.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.state?view=word-pia"/>
  public WdMailMergeState State { get; }

  /// <summary>
  /// Returns or sets the destination.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.destination?view=word-pia"/>
  public WdMailMergeDestination Destination { get; set; }

  /// <summary>
  /// Returns the data source.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.datasource?view=word-pia"/>
  public MailMergeDataSource DataSource { get; }

  /// <summary>
  /// Returns the fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.fields?view=word-pia"/>
  public MailMergeFields Fields { get; }

  /// <summary>
  /// Returns or sets the view mail merge field codes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.viewmailmergefieldcodes?view=word-pia"/>
  public int ViewMailMergeFieldCodes { get; set; }

  /// <summary>
  /// Returns or sets whether suppress blank lines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.suppressblanklines?view=word-pia"/>
  public bool SuppressBlankLines { get; set; }

  /// <summary>
  /// Returns or sets whether mail as attachment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.mailasattachment?view=word-pia"/>
  public bool MailAsAttachment { get; set; }

  /// <summary>
  /// Returns or sets the mail address field name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.mailaddressfieldname?view=word-pia"/>
  public string MailAddressFieldName { get; set; }

  /// <summary>
  /// Returns or sets the mail subject.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.mailsubject?view=word-pia"/>
  public string MailSubject { get; set; }

  /// <summary>
  /// Returns or sets whether highlight merge fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.highlightmergefields?view=word-pia"/>
  public bool HighlightMergeFields { get; set; }

  /// <summary>
  /// Returns or sets the mail format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.mailformat?view=word-pia"/>
  public WdMailMergeMailFormat MailFormat { get; set; }

  /// <summary>
  /// Returns or sets the show send to custom.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.showsendtocustom?view=word-pia"/>
  public string ShowSendToCustom { get; set; }

  /// <summary>
  /// Returns or sets the wizard state.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.wizardstate?view=word-pia"/>
  public int WizardState { get; set; }
}
