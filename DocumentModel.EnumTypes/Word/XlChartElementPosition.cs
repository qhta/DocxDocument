namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of the chart element.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlchartelementposition?view=office-pia` for Office interop details.
/// </remarks>
public enum XlChartElementPosition
{
  /// <summary>
  /// Specifies a specific position for the chart element.
  /// </summary>
  Custom = -4114,
  /// <summary>
  /// Automatically sets the position of the chart element.
  /// </summary>
  Automatic = -4105
}
