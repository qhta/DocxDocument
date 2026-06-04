namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the relative position of a table in the document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtableposition?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdTablePosition))]
public enum TablePosition
{
  /// <summary>
  /// At the top of the document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTablePosition.wdTableTop))]
  Top = -999999,
  /// <summary>
  /// Aligned to the left side of the document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTablePosition.wdTableLeft))]
  Left = -999998,
  /// <summary>
  /// At the bottom of the document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTablePosition.wdTableBottom))]
  Bottom = -999997,
  /// <summary>
  /// Aligned to the right side of the document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTablePosition.wdTableRight))]
  Right = -999996,
  /// <summary>
  /// Centered.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTablePosition.wdTableCenter))]
  Center = -999995,
  /// <summary>
  /// Placed inside a range.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTablePosition.wdTableInside))]
  Inside = -999994,
  /// <summary>
  /// Placed outside a range.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTablePosition.wdTableOutside))]
  Outside = -999993
}
