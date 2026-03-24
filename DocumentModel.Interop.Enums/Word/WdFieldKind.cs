namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of field for a Field object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdfieldkind?view=office-pia` for Office interop details.
/// </remarks>
public enum WdFieldKind
{
  /// <summary>
  /// Specifies the type of field for a Field object.
  /// </summary>
  None = 0,
  /// <summary>
  /// Specifies the type of field for a Field object.
  /// </summary>
  Hot = 1,
  /// <summary>
  /// A field that can be updated and has a result. This type includes fields that are automatically updated when
  /// the source changes as well as fields that can be manually updated (for example, DATE or INCLUDETEXT).
  /// wdFieldKindCold3 A field that doesn't have a result, for example, an Index Entry (XE), Table of Contents Entry
  /// (TC), or Private field.
  /// </summary>
  Warm = 2,
  /// <summary>
  /// Specifies the type of field for a Field object.
  /// </summary>
  Cold = 3
}
