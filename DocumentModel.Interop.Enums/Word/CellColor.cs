namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the color of highlighting for table cells that were added, deleted, or merged in the current
/// document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcellcolor?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdCellColor))]
public enum CellColor
{
  /// <summary>
  /// No highlighting.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCellColor.wdCellColorNoHighlight))]
  NoHighlight = 0,
  /// <summary>
  /// Pink.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCellColor.wdCellColorPink))]
  Pink = 1,
  /// <summary>
  /// Light blue.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCellColor.wdCellColorLightBlue))]
  LightBlue = 2,
  /// <summary>
  /// Light yellow.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCellColor.wdCellColorLightYellow))]
  LightYellow = 3,
  /// <summary>
  /// Light purple.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCellColor.wdCellColorLightPurple))]
  LightPurple = 4,
  /// <summary>
  /// Light orange.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCellColor.wdCellColorLightOrange))]
  LightOrange = 5,
  /// <summary>
  /// Light green.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCellColor.wdCellColorLightGreen))]
  LightGreen = 6,
  /// <summary>
  /// Light gray.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCellColor.wdCellColorLightGray))]
  LightGray = 7,
  /// <summary>
  /// Highlighting color determined by reviewer.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCellColor.wdCellColorByAuthor))]
  ByAuthor = -1
}
