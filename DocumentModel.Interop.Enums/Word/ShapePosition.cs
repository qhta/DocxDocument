namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the relative position of the specified shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdshapeposition?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdShapePosition))]
public enum ShapePosition
{
  /// <summary>
  /// At the top.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdShapePosition.wdShapeTop))]
  Top = -999999,
  /// <summary>
  /// On the left.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdShapePosition.wdShapeLeft))]
  Left = -999998,
  /// <summary>
  /// At the bottom.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdShapePosition.wdShapeBottom))]
  Bottom = -999997,
  /// <summary>
  /// On the right.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdShapePosition.wdShapeRight))]
  Right = -999996,
  /// <summary>
  /// In the center.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdShapePosition.wdShapeCenter))]
  Center = -999995,
  /// <summary>
  /// Inside the selected range.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdShapePosition.wdShapeInside))]
  Inside = -999994,
  /// <summary>
  /// Outside the selected range.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdShapePosition.wdShapeOutside))]
  Outside = -999993
}
