namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a unit of measure to use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmeasurementunits?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdMeasurementUnits")]
public enum MeasurementUnits
{
  /// <summary>
  /// Inches.
  /// </summary>
  [InteropEnumValue("wdInches")]
  Inches = 0,
  /// <summary>
  /// Centimeters.
  /// </summary>
  [InteropEnumValue("wdCentimeters")]
  Centimeters = 1,
  /// <summary>
  /// Millimeters.
  /// </summary>
  [InteropEnumValue("wdMillimeters")]
  Millimeters = 2,
  /// <summary>
  /// Points.
  /// </summary>
  [InteropEnumValue("wdPoints")]
  Points = 3,
  /// <summary>
  /// Picas (commonly used in traditional typewriter font spacing).
  /// </summary>
  [InteropEnumValue("wdPicas")]
  Picas = 4
}
