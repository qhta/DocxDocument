namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Word wraps text around pictures.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdwraptypemerged?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdWrapTypeMerged))]
public enum WrapTypeMerged
{
  /// <summary>
  /// In line with text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWrapTypeMerged.wdWrapMergeInline))]
  Inline = 0,
  /// <summary>
  /// Square.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWrapTypeMerged.wdWrapMergeSquare))]
  Square = 1,
  /// <summary>
  /// Tight.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWrapTypeMerged.wdWrapMergeTight))]
  Tight = 2,
  /// <summary>
  /// Behind text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWrapTypeMerged.wdWrapMergeBehind))]
  Behind = 3,
  /// <summary>
  /// In front of text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWrapTypeMerged.wdWrapMergeFront))]
  Front = 4,
  /// <summary>
  /// Through.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWrapTypeMerged.wdWrapMergeThrough))]
  Through = 5,
  /// <summary>
  /// Top and bottom.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWrapTypeMerged.wdWrapMergeTopBottom))]
  TopBottom = 6
}
