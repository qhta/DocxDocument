namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the relative position of the specified shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdshapeposition?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdShapePosition")]
public enum ShapePosition
{
  /// <summary>
  /// At the top.
  /// </summary>
  [WordInteropEnumValue("wdShapeTop")]
  Top = -999999,
  /// <summary>
  /// On the left.
  /// </summary>
  [WordInteropEnumValue("wdShapeLeft")]
  Left = -999998,
  /// <summary>
  /// At the bottom.
  /// </summary>
  [WordInteropEnumValue("wdShapeBottom")]
  Bottom = -999997,
  /// <summary>
  /// On the right.
  /// </summary>
  [WordInteropEnumValue("wdShapeRight")]
  Right = -999996,
  /// <summary>
  /// In the center.
  /// </summary>
  [WordInteropEnumValue("wdShapeCenter")]
  Center = -999995,
  /// <summary>
  /// Inside the selected range.
  /// </summary>
  [WordInteropEnumValue("wdShapeInside")]
  Inside = -999994,
  /// <summary>
  /// Outside the selected range.
  /// </summary>
  [WordInteropEnumValue("wdShapeOutside")]
  Outside = -999993
}
