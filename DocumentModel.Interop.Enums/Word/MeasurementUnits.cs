namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a unit of measure to use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmeasurementunits?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdMeasurementUnits))]
public enum MeasurementUnits
{
  /// <summary>
  /// Inches.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMeasurementUnits.wdInches))]
  Inches = 0,
  /// <summary>
  /// Centimeters.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMeasurementUnits.wdCentimeters))]
  Centimeters = 1,
  /// <summary>
  /// Millimeters.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMeasurementUnits.wdMillimeters))]
  Millimeters = 2,
  /// <summary>
  /// Points.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMeasurementUnits.wdPoints))]
  Points = 3,
  /// <summary>
  /// Picas (commonly used in traditional typewriter font spacing).
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMeasurementUnits.wdPicas))]
  Picas = 4
}
