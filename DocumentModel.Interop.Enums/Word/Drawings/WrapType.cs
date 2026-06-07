namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the wrap type for the specified shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdwraptype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdWrapType")]
public enum WrapType
{
  /// <summary>
  /// Wraps text around the shape. Line continuation is on the opposite side of the shape.
  /// </summary>
  [InteropEnumValue("wdWrapSquare")]
  Square = 0,
  /// <summary>
  /// Tight.
  /// </summary>
  [InteropEnumValue("wdWrapTight")]
  Tight = 1,
  /// <summary>
  /// Through.
  /// </summary>
  [InteropEnumValue("wdWrapThrough")]
  Through = 2,
  /// <summary>
  /// Behind text.
  /// </summary>
  [InteropEnumValue("wdWrapNone")]
  None = 3,
  /// <summary>
  /// Places shape in front of text.
  /// </summary>
  [InteropEnumValue("wdWrapFront")]
  Front = 3,
  /// <summary>
  /// Top and bottom.
  /// </summary>
  [InteropEnumValue("wdWrapTopBottom")]
  TopBottom = 4,
  /// <summary>
  /// Places shape behind text.
  /// </summary>
  [InteropEnumValue("wdWrapBehind")]
  Behind = 5,
  /// <summary>
  /// In line with text.
  /// </summary>
  [InteropEnumValue("wdWrapInline")]
  Inline = 7
}
