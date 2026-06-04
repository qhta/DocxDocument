namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the state (shape) of the cursor.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcursortype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdCursorType")]
public enum CursorType
{
  /// <summary>
  /// Hourglass cursor shape.
  /// </summary>
  [InteropEnumValue("wdCursorWait")]
  Wait = 0,
  /// <summary>
  /// I-beam cursor shape.
  /// </summary>
  [InteropEnumValue("wdCursorIBeam")]
  IBeam = 1,
  /// <summary>
  /// Normal cursor shape. Default; cursor takes shape designated by Microsoft Windows or the application.
  /// </summary>
  [InteropEnumValue("wdCursorNormal")]
  Normal = 2,
  /// <summary>
  /// Diagonal cursor shape starting at top left corner.
  /// </summary>
  [InteropEnumValue("wdCursorNorthwestArrow")]
  NorthwestArrow = 3
}
