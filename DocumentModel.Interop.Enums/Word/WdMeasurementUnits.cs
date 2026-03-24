namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a unit of measure to use.
/// </summary>
public enum WdMeasurementUnits
{
  /// <summary>
  /// Inches.
  /// </summary>
  Inches = unchecked((int)0),
  /// <summary>
  /// Centimeters.
  /// </summary>
  Centimeters = unchecked((int)1),
  /// <summary>
  /// Millimeters.
  /// </summary>
  Millimeters = unchecked((int)2),
  /// <summary>
  /// Points.
  /// </summary>
  Points = unchecked((int)3),
  /// <summary>
  /// Picas (commonly used in traditional typewriter font spacing).
  /// </summary>
  Picas = unchecked((int)4)
}
