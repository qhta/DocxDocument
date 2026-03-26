namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a unit of measure to use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmeasurementunits?view=office-pia` for Office interop details.
/// </remarks>
public enum MeasurementUnits
{
  /// <summary>
  /// Inches.
  /// </summary>
  Inches = 0,
  /// <summary>
  /// Centimeters.
  /// </summary>
  Centimeters = 1,
  /// <summary>
  /// Millimeters.
  /// </summary>
  Millimeters = 2,
  /// <summary>
  /// Points.
  /// </summary>
  Points = 3,
  /// <summary>
  /// Picas (commonly used in traditional typewriter font spacing).
  /// </summary>
  Picas = 4
}
