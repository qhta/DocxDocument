namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the background type for text in charts.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.xlbackground?view=office-pia` for Office interop details.
/// </remarks>
public enum XlBackground
{
  /// <summary>
  /// Transparent background.
  /// </summary>
  Transparent = 2,
  /// <summary>
  /// Opaque background.
  /// </summary>
  Opaque = 3,
  /// <summary>
  /// Word controls the background.
  /// </summary>
  Automatic = -4105
}
