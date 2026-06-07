namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the state of a mail merge operation.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmailmergestate?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdMailMergeState")]
public enum MailMergeState
{
  /// <summary>
  /// Document is not involved in a mail merge operation.
  /// </summary>
  [InteropEnumValue("wdNormalDocument")]
  NormalDocument = 0,
  /// <summary>
  /// A main document with no data attached.
  /// </summary>
  [InteropEnumValue("wdMainDocumentOnly")]
  MainDocumentOnly = 1,
  /// <summary>
  /// A main document with an attached data source.
  /// </summary>
  [InteropEnumValue("wdMainAndDataSource")]
  MainAndDataSource = 2,
  /// <summary>
  /// A main document with an attached header source.
  /// </summary>
  [InteropEnumValue("wdMainAndHeader")]
  MainAndHeader = 3,
  /// <summary>
  /// A main document with attached data source and header source.
  /// </summary>
  [InteropEnumValue("wdMainAndSourceAndHeader")]
  MainAndSourceAndHeader = 4,
  /// <summary>
  /// A data source with no main document.
  /// </summary>
  [InteropEnumValue("wdDataSource")]
  DataSource = 5
}
