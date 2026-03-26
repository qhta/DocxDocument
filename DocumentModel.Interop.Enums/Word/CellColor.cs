namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the color of highlighting for table cells that were added, deleted, or merged in the current
/// document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcellcolor?view=office-pia` for Office interop details.
/// </remarks>
public enum CellColor
{
  /// <summary>
  /// No highlighting.
  /// </summary>
  NoHighlight = 0,
  /// <summary>
  /// Pink.
  /// </summary>
  Pink = 1,
  /// <summary>
  /// Light blue.
  /// </summary>
  LightBlue = 2,
  /// <summary>
  /// Light yellow.
  /// </summary>
  LightYellow = 3,
  /// <summary>
  /// Light purple.
  /// </summary>
  LightPurple = 4,
  /// <summary>
  /// Light orange.
  /// </summary>
  LightOrange = 5,
  /// <summary>
  /// Light green.
  /// </summary>
  LightGreen = 6,
  /// <summary>
  /// Light gray.
  /// </summary>
  LightGray = 7,
  /// <summary>
  /// Highlighting color determined by reviewer.
  /// </summary>
  ByAuthor = -1
}
