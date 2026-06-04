namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Word wraps text around pictures.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdwraptypemerged?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdWrapTypeMerged")]
public enum WrapTypeMerged
{
  /// <summary>
  /// In line with text.
  /// </summary>
  [WordInteropEnumValue("wdWrapMergeInline")]
  Inline = 0,
  /// <summary>
  /// Square.
  /// </summary>
  [WordInteropEnumValue("wdWrapMergeSquare")]
  Square = 1,
  /// <summary>
  /// Tight.
  /// </summary>
  [WordInteropEnumValue("wdWrapMergeTight")]
  Tight = 2,
  /// <summary>
  /// Behind text.
  /// </summary>
  [WordInteropEnumValue("wdWrapMergeBehind")]
  Behind = 3,
  /// <summary>
  /// In front of text.
  /// </summary>
  [WordInteropEnumValue("wdWrapMergeFront")]
  Front = 4,
  /// <summary>
  /// Through.
  /// </summary>
  [WordInteropEnumValue("wdWrapMergeThrough")]
  Through = 5,
  /// <summary>
  /// Top and bottom.
  /// </summary>
  [WordInteropEnumValue("wdWrapMergeTopBottom")]
  TopBottom = 6
}
