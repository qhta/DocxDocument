namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the wrap type for the specified shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdwraptype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdWrapType")]
public enum WrapType
{
  /// <summary>
  /// Wraps text around the shape. Line continuation is on the opposite side of the shape.
  /// </summary>
  [WordInteropEnumValue("wdWrapSquare")]
  Square = 0,
  /// <summary>
  /// Tight.
  /// </summary>
  [WordInteropEnumValue("wdWrapTight")]
  Tight = 1,
  /// <summary>
  /// Through.
  /// </summary>
  [WordInteropEnumValue("wdWrapThrough")]
  Through = 2,
  /// <summary>
  /// Behind text.
  /// </summary>
  [WordInteropEnumValue("wdWrapNone")]
  None = 3,
  /// <summary>
  /// Places shape in front of text.
  /// </summary>
  [WordInteropEnumValue("wdWrapFront")]
  Front = 3,
  /// <summary>
  /// Top and bottom.
  /// </summary>
  [WordInteropEnumValue("wdWrapTopBottom")]
  TopBottom = 4,
  /// <summary>
  /// Places shape behind text.
  /// </summary>
  [WordInteropEnumValue("wdWrapBehind")]
  Behind = 5,
  /// <summary>
  /// In line with text.
  /// </summary>
  [WordInteropEnumValue("wdWrapInline")]
  Inline = 7
}
