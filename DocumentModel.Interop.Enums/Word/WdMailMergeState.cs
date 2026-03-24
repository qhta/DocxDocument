namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the state of a mail merge operation.
/// </summary>
public enum WdMailMergeState
{
  /// <summary>
  /// Document is not involved in a mail merge operation.
  /// </summary>
  NormalDocument = unchecked((int)0),
  /// <summary>
  /// A main document with no data attached.
  /// </summary>
  MainDocumentOnly = unchecked((int)1),
  /// <summary>
  /// A main document with an attached data source.
  /// </summary>
  MainAndDataSource = unchecked((int)2),
  /// <summary>
  /// A main document with an attached header source. wdMainAndSourceAndHeader4 A main document with attached data
  /// source and header source.
  /// </summary>
  MainAndHeader = unchecked((int)3),
  /// <summary>
  /// Specifies the state of a mail merge operation.
  /// </summary>
  MainAndSourceAndHeader = unchecked((int)4),
  /// <summary>
  /// A data source with no main document.
  /// </summary>
  DataSource = unchecked((int)5)
}
