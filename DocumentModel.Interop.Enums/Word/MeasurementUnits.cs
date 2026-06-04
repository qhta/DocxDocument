namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a unit of measure to use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmeasurementunits?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdMeasurementUnits")]
public enum MeasurementUnits
{
  /// <summary>
  /// Inches.
  /// </summary>
  [WordInteropEnumValue("wdInches")]
  Inches = 0,
  /// <summary>
  /// Centimeters.
  /// </summary>
  [WordInteropEnumValue("wdCentimeters")]
  Centimeters = 1,
  /// <summary>
  /// Millimeters.
  /// </summary>
  [WordInteropEnumValue("wdMillimeters")]
  Millimeters = 2,
  /// <summary>
  /// Points.
  /// </summary>
  [WordInteropEnumValue("wdPoints")]
  Points = 3,
  /// <summary>
  /// Picas (commonly used in traditional typewriter font spacing).
  /// </summary>
  [WordInteropEnumValue("wdPicas")]
  Picas = 4
}
