namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the axis type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.xlaxistype?view=office-pia` for Office interop details.
/// </remarks>
public enum XlAxisType
{
  /// <summary>
  /// Axis displays categories.
  /// </summary>
  Category = 1,
  /// <summary>
  /// Axis displays values.
  /// </summary>
  Value = 2,
  /// <summary>
  /// Axis displays data series.
  /// </summary>
  SeriesAxis = 3
}
