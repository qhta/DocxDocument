namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of field for a Field object.
/// </summary>
public enum WdFieldKind
{
  /// <summary>
  /// Specifies the type of field for a Field object.
  /// </summary>
  None = unchecked((int)0),
  /// <summary>
  /// Specifies the type of field for a Field object.
  /// </summary>
  Hot = unchecked((int)1),
  /// <summary>
  /// A field that can be updated and has a result. This type includes fields that are automatically updated when
  /// the source changes as well as fields that can be manually updated (for example, DATE or INCLUDETEXT).
  /// wdFieldKindCold3 A field that doesn't have a result, for example, an Index Entry (XE), Table of Contents Entry
  /// (TC), or Private field.
  /// </summary>
  Warm = unchecked((int)2),
  /// <summary>
  /// Specifies the type of field for a Field object.
  /// </summary>
  Cold = unchecked((int)3)
}
