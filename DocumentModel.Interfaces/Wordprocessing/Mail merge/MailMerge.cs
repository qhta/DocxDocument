namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the mail merge functionality in Microsoft Word.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge?view=word-pia"/>
public partial interface IMailMerge : IModelObject
{
  /// <summary>
  /// Returns or sets the main document type.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.maindocumenttype?view=word-pia"/>
  public MailMergeMainDocType MainDocumentType { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns the current state of the mail merge operation.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.state?view=word-pia"/>
  public MailMergeState State { get; }

  /// <summary>
  /// Returns or sets the destination for the mail merge results.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.destination?view=word-pia"/>
  public MailMergeDestination Destination { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns the active data source for the mail merge operation.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.datasource?view=word-pia"/>
  public IMailMergeDataSource DataSource { get; }

  /// <summary>
  /// Returns the mail merge fields collection in the main document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.fields?view=word-pia"/>
  public IMailMergeFields Fields { get; }

  /// <summary>
  /// Returns or sets whether mail merge field codes are shown.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.viewmailmergefieldcodes?view=word-pia"/>
  public int ViewMailMergeFieldCodes { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets whether blank lines are suppressed in merged documents.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.suppressblanklines?view=word-pia"/>
  public bool SuppressBlankLines { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets whether merged e-mail messages are sent as attachments.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.mailasattachment?view=word-pia"/>
  public bool MailAsAttachment { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the data field name used for e-mail addresses.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.mailaddressfieldname?view=word-pia"/>
  public string MailAddressFieldName { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the e-mail subject line for merged messages.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.mailsubject?view=word-pia"/>
  public string MailSubject { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets whether mail merge fields are highlighted.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.highlightmergefields?view=word-pia"/>
  public bool HighlightMergeFields { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the format used for merged e-mail messages.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.mailformat?view=word-pia"/>
  public MailMergeMailFormat MailFormat { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets custom text for the Send To user interface option.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.showsendtocustom?view=word-pia"/>
  public string ShowSendToCustom { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the current step in the Mail Merge wizard.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.wizardstate?view=word-pia"/>
  public int WizardState { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}
