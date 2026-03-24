namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the state (shape) of the cursor.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcursortype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdCursorType
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
  /// Normal cursor shape. Default; cursor takes shape designated by Microsoft Windows or the application.
  /// </summary>
  Normal = 2,
  /// <summary>
  /// Specifies the state (shape) of the cursor.
  /// </summary>
  NorthwestArrow = 3
}
