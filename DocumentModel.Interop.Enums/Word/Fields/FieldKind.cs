namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of field for a Field object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdfieldkind?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdFieldKind")]
public enum FieldKind
{
  /// <summary>
  /// An invalid field (for example, a pair of field characters with nothing inside).
  /// </summary>
  [InteropEnumValue("wdFieldKindNone")]
  None = 0,
  /// <summary>
  /// A field that's automatically updated each time it's displayed or each time the page is reformatted, but which
  /// can also be manually updated (for example, INCLUDEPICTURE or FORMDROPDOWN).
  /// </summary>
  [InteropEnumValue("wdFieldKindHot")]
  Hot = 1,
  /// <summary>
  /// A field that can be updated and has a result. This type includes fields that are automatically updated when
  /// the source changes as well as fields that can be manually updated (for example, DATE or INCLUDETEXT).
  /// </summary>
  [InteropEnumValue("wdFieldKindWarm")]
  Warm = 2,
  /// <summary>
  /// A field that doesn't have a result, for example, an Index Entry (XE), Table of Contents Entry (TC), or Private
  /// field.
  /// </summary>
  [InteropEnumValue("wdFieldKindCold")]
  Cold = 3
}
