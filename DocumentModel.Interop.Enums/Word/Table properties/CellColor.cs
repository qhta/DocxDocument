namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the color of highlighting for table cells that were added, deleted, or merged in the current
/// document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcellcolor?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdCellColor")]
public enum CellColor
{
  /// <summary>
  /// No highlighting.
  /// </summary>
  [InteropEnumValue("wdCellColorNoHighlight")]
  NoHighlight = 0,
  /// <summary>
  /// Pink.
  /// </summary>
  [InteropEnumValue("wdCellColorPink")]
  Pink = 1,
  /// <summary>
  /// Light blue.
  /// </summary>
  [InteropEnumValue("wdCellColorLightBlue")]
  LightBlue = 2,
  /// <summary>
  /// Light yellow.
  /// </summary>
  [InteropEnumValue("wdCellColorLightYellow")]
  LightYellow = 3,
  /// <summary>
  /// Light purple.
  /// </summary>
  [InteropEnumValue("wdCellColorLightPurple")]
  LightPurple = 4,
  /// <summary>
  /// Light orange.
  /// </summary>
  [InteropEnumValue("wdCellColorLightOrange")]
  LightOrange = 5,
  /// <summary>
  /// Light green.
  /// </summary>
  [InteropEnumValue("wdCellColorLightGreen")]
  LightGreen = 6,
  /// <summary>
  /// Light gray.
  /// </summary>
  [InteropEnumValue("wdCellColorLightGray")]
  LightGray = 7,
  /// <summary>
  /// Highlighting color determined by reviewer.
  /// </summary>
  [InteropEnumValue("wdCellColorByAuthor")]
  ByAuthor = -1
}
