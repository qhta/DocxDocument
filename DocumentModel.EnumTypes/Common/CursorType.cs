namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the state (shape) of the cursor.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcursortype?view=office-pia` for Office interop details.
/// </remarks>
public enum CursorType
{
  /// <summary>
  /// Hourglass cursor shape.
  /// </summary>
  Wait = 0,
  /// <summary>
  /// I-beam cursor shape.
  /// </summary>
  IBeam = 1,
  /// <summary>
  /// Normal cursor shape. Default; cursor takes shape designated by Microsoft IWindows or the application.
  /// </summary>
  Normal = 2,
  /// <summary>
  /// Diagonal cursor shape starting at top left corner.
  /// </summary>
  NorthwestArrow = 3
}

