namespace DocumentModel;

/// <summary>
/// Helper class for normalizing color values, such as clamping values to specific ranges and rounding them to a defined precision.
/// </summary>
public static class ColorNormalization
{

  /// <summary>
  /// Normalizes a Percentage value to the range [0.0, 1.0] and rounds it to 6 decimal places.
  /// </summary>
  /// <param name="percentage"></param>
  /// <returns></returns>
  public static double Clamp01(this Percentage percentage)
    => (percentage.AsDouble()).Clamp01();

  /// <summary>
  /// Normalizes a double value to the range [0.0, 1.0] and rounds it to 16 decimal places.
  /// </summary>
  /// <param name="value">The value to be normalized.</param>
  /// <returns>The normalized value.</returns>
  public static double Clamp01(this double value)
  {
    value = value < 0.0 ? 0.0 : value > 1.0 ? 1.0 : value;
    value = (double)System.Math.Round(value, 6);
    return value;
  }

  /// <summary>
  /// Normalizes a Degrees value to the range [0.0, 360.0) and rounds it to 6 decimal places.
  /// </summary>
  /// <param name="degrees">The Degrees value to be normalized.</param>
  /// <returns>The normalized value.</returns>
  public static double NormalizeHue(this Degrees degrees)
    => ((double)degrees.Value).NormalizeHue();

  /// <summary>1
  /// Normalizes a double value to the range [0.0, 360.0) and rounds it to 6 decimal places.
  /// </summary>
  /// <param name="value">The value to be normalized.</param>
  /// <returns>The normalized value.</returns>
  public static double NormalizeHue(this double value)
  {
    value %= 360.0;
    value = value < 0.0 ? value + 360.0 : value;
    var decValue = (decimal)value;
    value = (double)System.Math.Round(decValue, 6);
    return value;
  }
}