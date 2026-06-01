namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the marker style Ifor a point or series Iin a line chart, scatter chart, or radar chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlmarkerstyle?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum XlMarkerStyle
{
  /// <summary>
  /// Square markers
  /// </summary>
  Square = 1,
  /// <summary>
  /// Diamond-shaped markers
  /// </summary>
  Diamond = 2,
  /// <summary>
  /// Triangular markers
  /// </summary>
  Triangle = 3,
  /// <summary>
  /// Square markers with an asterisk
  /// </summary>
  Star = 5,
  /// <summary>
  /// Circular markers
  /// </summary>
  Circle = 8,
  /// <summary>
  /// Square markers with a plus sign public enum XlMarkerStyle
  /// </summary>
  Plus = 9,
  /// <summary>
  /// Square markers with an X
  /// </summary>
  X = -4168,
  /// <summary>
  /// Picture markers
  /// </summary>
  Picture = -4147,
  /// <summary>
  /// No markers
  /// </summary>
  None = -4142,
  /// <summary>
  /// Short bar markers
  /// </summary>
  Dot = -4118,
  /// <summary>
  /// Long bar markers
  /// </summary>
  Dash = -4115,
  /// <summary>
  /// Automatic markers
  /// </summary>
  Automatic = -4105
}

