namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the state of a mail merge operation.
/// </summary>
public enum WdMailMergeState
{
  /// <summary>
  /// Document is not involved in a mail merge operation.
  /// </summary>
  NormalDocument = 0,
  /// <summary>
  /// A main document with no data attached.
  /// </summary>
  MainDocumentOnly = 1,
  /// <summary>
  /// A main document with an attached data source.
  /// </summary>
  MainAndDataSource = 2,
  /// <summary>
  /// A main document with an attached header source. wdMainAndSourceAndHeader4 A main document with attached data
  /// source and header source.
  /// </summary>
  MainAndHeader = 3,
  /// <summary>
  /// Specifies the state of a mail merge operation.
  /// </summary>
  MainAndSourceAndHeader = 4,
  /// <summary>
  /// A data source with no main document.
  /// </summary>
  DataSource = 5
}
