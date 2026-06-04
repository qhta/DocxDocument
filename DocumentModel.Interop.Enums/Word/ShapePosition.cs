namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the relative position of the specified shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdshapeposition?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdShapePosition")]
public enum ShapePosition
{
  /// <summary>
  /// At the top.
  /// </summary>
  [InteropEnumValue("wdShapeTop")]
  Top = -999999,
  /// <summary>
  /// On the left.
  /// </summary>
  [InteropEnumValue("wdShapeLeft")]
  Left = -999998,
  /// <summary>
  /// At the bottom.
  /// </summary>
  [InteropEnumValue("wdShapeBottom")]
  Bottom = -999997,
  /// <summary>
  /// On the right.
  /// </summary>
  [InteropEnumValue("wdShapeRight")]
  Right = -999996,
  /// <summary>
  /// In the center.
  /// </summary>
  [InteropEnumValue("wdShapeCenter")]
  Center = -999995,
  /// <summary>
  /// Inside the selected range.
  /// </summary>
  [InteropEnumValue("wdShapeInside")]
  Inside = -999994,
  /// <summary>
  /// Outside the selected range.
  /// </summary>
  [InteropEnumValue("wdShapeOutside")]
  Outside = -999993
}
