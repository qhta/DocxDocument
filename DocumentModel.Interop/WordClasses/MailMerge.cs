namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the mail merge functionality in Microsoft Word.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge?view=word-pia"/>
public partial class MailMerge : InteropObject
{
  /// <summary>
  /// Returns or sets the main document type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.maindocumenttype?view=word-pia"/>
  public MailMergeMainDocType MainDocumentType { get; set; }

  /// <summary>
  /// Returns the current state of the mail merge operation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.state?view=word-pia"/>
  public MailMergeState State { get; set; }

  /// <summary>
  /// Returns or sets the destination for the mail merge results.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.destination?view=word-pia"/>
  public MailMergeDestination Destination { get; set; }

  /// <summary>
  /// Returns the active data source for the mail merge operation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.datasource?view=word-pia"/>
  public MailMergeDataSourceType DataSource { get; set; }

  /// <summary>
  /// Returns the mail merge fields collection in the main document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.fields?view=word-pia"/>
  public MailMergeFields Fields { get; private set; } = new MailMergeFields();

  /// <summary>
  /// Returns or sets whether mail merge field codes are shown.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.viewmailmergefieldcodes?view=word-pia"/>
  public int ViewMailMergeFieldCodes { get; set; }

  /// <summary>
  /// Returns or sets whether blank lines are suppressed in merged documents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.suppressblanklines?view=word-pia"/>
  public bool SuppressBlankLines { get; set; }

  /// <summary>
  /// Returns or sets whether merged e-mail messages are sent as attachments.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.mailasattachment?view=word-pia"/>
  public bool MailAsAttachment { get; set; }

  /// <summary>
  /// Returns or sets the data field name used for e-mail addresses.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.mailaddressfieldname?view=word-pia"/>
  public string? MailAddressFieldName { get; set; }

  /// <summary>
  /// Returns or sets the e-mail subject line for merged messages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.mailsubject?view=word-pia"/>
  public string? MailSubject { get; set; }

  /// <summary>
  /// Returns or sets whether mail merge fields are highlighted.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.highlightmergefields?view=word-pia"/>
  public bool HighlightMergeFields { get; set; }

  /// <summary>
  /// Returns or sets the format used for merged e-mail messages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.mailformat?view=word-pia"/>
  public MailMergeMailFormat MailFormat { get; set; }

  /// <summary>
  /// Returns or sets custom text for the Send To user class option.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.showsendtocustom?view=word-pia"/>
  public string? ShowSendToCustom { get; set; }

  /// <summary>
  /// Returns or sets the current step in the Mail Merge wizard.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.wizardstate?view=word-pia"/>
  public int WizardState { get; set; }


  #region methods

/// <summary>
  /// Creates a new mail merge data source.
  /// </summary>
  /// <param name="name">Specifies the data source file name.</param>
  /// <param name="passwordDocument">Specifies the password to open the document.</param>
  /// <param name="writePasswordDocument">Specifies the password to save changes.</param>
  /// <param name="headerRecord">Specifies the header record text.</param>
  /// <param name="mSQuery">Specifies Microsoft Query data.</param>
  /// <param name="sQLStatement">Specifies the first SQL statement.</param>
  /// <param name="sQLStatement1">Specifies the second SQL statement.</param>
  /// <param name="connection">Specifies the data connection string.</param>
  /// <param name="linkToSource">Specifies whether the main document links to the data source.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmerge.createdatasource?view=word-pia"/>
  public void CreateDataSource(string name, string passwordDocument, string writePasswordDocument, string headerRecord, 
    string mSQuery, string sQLStatement, string sQLStatement1, string connection, bool linkToSource)
  {
    throw new NotImplementedException();
  }

  #endregion methods
}
