namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the wrap type for the specified shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdwraptype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdWrapType))]
public enum WrapType
{
  /// <summary>
  /// Wraps text around the shape. Line continuation is on the opposite side of the shape.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWrapType.wdWrapSquare))]
  Square = 0,
  /// <summary>
  /// Tight.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWrapType.wdWrapTight))]
  Tight = 1,
  /// <summary>
  /// Through.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWrapType.wdWrapThrough))]
  Through = 2,
  /// <summary>
  /// Behind text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWrapType.wdWrapNone))]
  None = 3,
  /// <summary>
  /// Places shape in front of text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWrapType.wdWrapFront))]
  Front = 3,
  /// <summary>
  /// Top and bottom.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWrapType.wdWrapTopBottom))]
  TopBottom = 4,
  /// <summary>
  /// Places shape behind text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWrapType.wdWrapBehind))]
  Behind = 5,
  /// <summary>
  /// In line with text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWrapType.wdWrapInline))]
  Inline = 7
}
