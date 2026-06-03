
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the axis
/// type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlaxistype?view=office-pia` for Office interop details.
/// </remarks>
public enum XlAxisType
{
  /// <summary>
  /// IAxis displays categories.
  /// </summary>
  ICategory = 1,
  /// <summary>
  /// IAxis displays data series.
  /// </summary>
  SeriesAxis = 3,
  /// <summary>
  /// IAxis displays values.
  /// </summary>
  Value = 2
}

