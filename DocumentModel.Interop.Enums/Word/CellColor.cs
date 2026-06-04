namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the color of highlighting for table cells that were added, deleted, or merged in the current
/// document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcellcolor?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdCellColor")]
public enum CellColor
{
  /// <summary>
  /// No highlighting.
  /// </summary>
  [WordInteropEnumValue("wdCellColorNoHighlight")]
  NoHighlight = 0,
  /// <summary>
  /// Pink.
  /// </summary>
  [WordInteropEnumValue("wdCellColorPink")]
  Pink = 1,
  /// <summary>
  /// Light blue.
  /// </summary>
  [WordInteropEnumValue("wdCellColorLightBlue")]
  LightBlue = 2,
  /// <summary>
  /// Light yellow.
  /// </summary>
  [WordInteropEnumValue("wdCellColorLightYellow")]
  LightYellow = 3,
  /// <summary>
  /// Light purple.
  /// </summary>
  [WordInteropEnumValue("wdCellColorLightPurple")]
  LightPurple = 4,
  /// <summary>
  /// Light orange.
  /// </summary>
  [WordInteropEnumValue("wdCellColorLightOrange")]
  LightOrange = 5,
  /// <summary>
  /// Light green.
  /// </summary>
  [WordInteropEnumValue("wdCellColorLightGreen")]
  LightGreen = 6,
  /// <summary>
  /// Light gray.
  /// </summary>
  [WordInteropEnumValue("wdCellColorLightGray")]
  LightGray = 7,
  /// <summary>
  /// Highlighting color determined by reviewer.
  /// </summary>
  [WordInteropEnumValue("wdCellColorByAuthor")]
  ByAuthor = -1
}
