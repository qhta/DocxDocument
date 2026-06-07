namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Word wraps text around pictures.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdwraptypemerged?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdWrapTypeMerged")]
public enum WrapTypeMerged
{
  /// <summary>
  /// In line with text.
  /// </summary>
  [InteropEnumValue("wdWrapMergeInline")]
  Inline = 0,
  /// <summary>
  /// Square.
  /// </summary>
  [InteropEnumValue("wdWrapMergeSquare")]
  Square = 1,
  /// <summary>
  /// Tight.
  /// </summary>
  [InteropEnumValue("wdWrapMergeTight")]
  Tight = 2,
  /// <summary>
  /// Behind text.
  /// </summary>
  [InteropEnumValue("wdWrapMergeBehind")]
  Behind = 3,
  /// <summary>
  /// In front of text.
  /// </summary>
  [InteropEnumValue("wdWrapMergeFront")]
  Front = 4,
  /// <summary>
  /// Through.
  /// </summary>
  [InteropEnumValue("wdWrapMergeThrough")]
  Through = 5,
  /// <summary>
  /// Top and bottom.
  /// </summary>
  [InteropEnumValue("wdWrapMergeTopBottom")]
  TopBottom = 6
}
