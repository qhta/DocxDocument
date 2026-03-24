namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the state of the option for automatically saving document versions.
/// </summary>
public enum WdAutoVersions
{
  /// <summary>
  /// No document version is saved. wdAutoVersionOnClose1 A document version is saved automatically when the
  /// document is closed.
  /// </summary>
  ff = 0,
  /// <summary>
  /// Specifies the state of the option for automatically saving document versions.
  /// </summary>
  nClose = 1
}
