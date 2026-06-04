namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the state of a mail merge operation.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmailmergestate?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdMailMergeState")]
public enum MailMergeState
{
  /// <summary>
  /// Document is not involved in a mail merge operation.
  /// </summary>
  [WordInteropEnumValue("wdNormalDocument")]
  NormalDocument = 0,
  /// <summary>
  /// A main document with no data attached.
  /// </summary>
  [WordInteropEnumValue("wdMainDocumentOnly")]
  MainDocumentOnly = 1,
  /// <summary>
  /// A main document with an attached data source.
  /// </summary>
  [WordInteropEnumValue("wdMainAndDataSource")]
  MainAndDataSource = 2,
  /// <summary>
  /// A main document with an attached header source.
  /// </summary>
  [WordInteropEnumValue("wdMainAndHeader")]
  MainAndHeader = 3,
  /// <summary>
  /// A main document with attached data source and header source.
  /// </summary>
  [WordInteropEnumValue("wdMainAndSourceAndHeader")]
  MainAndSourceAndHeader = 4,
  /// <summary>
  /// A data source with no main document.
  /// </summary>
  [WordInteropEnumValue("wdDataSource")]
  DataSource = 5
}
