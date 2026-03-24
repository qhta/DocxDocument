namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the orientation of revision and comment balloons when they are printed.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrevisionsballoonprintorientation?view=office-pia` for Office interop details.
/// </remarks>
public enum WdRevisionsBalloonPrintOrientation
{
  /// <summary>
  /// Specifies the orientation of revision and comment balloons when they are printed.
  /// </summary>
  Auto = 0,
  /// <summary>
  /// Specifies the orientation of revision and comment balloons when they are printed.
  /// </summary>
  Preserve = 1,
  /// <summary>
  /// Specifies the orientation of revision and comment balloons when they are printed.
  /// </summary>
  ForceLandscape = 2
}
