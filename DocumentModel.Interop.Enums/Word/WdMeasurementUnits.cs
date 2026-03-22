namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a unit of measure to use.
/// </summary>
public enum WdMeasurementUnits
{
  /// <summary>
  /// Inches.
  /// </summary>
  wdInches = unchecked((int)0),
  /// <summary>
  /// Centimeters.
  /// </summary>
  wdCentimeters = unchecked((int)1),
  /// <summary>
  /// Millimeters.
  /// </summary>
  wdMillimeters = unchecked((int)2),
  /// <summary>
  /// Points.
  /// </summary>
  wdPoints = unchecked((int)3),
  /// <summary>
  /// Picas (commonly used in traditional typewriter font spacing).
  /// </summary>
  wdPicas = unchecked((int)4)
}
