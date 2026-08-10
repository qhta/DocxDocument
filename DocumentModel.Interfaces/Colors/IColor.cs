namespace DocumentModel;

/// <summary>
/// Full color interface, supporting both RGB and theme colors.
/// </summary>
public interface IColor
{
  /// <summary>A value of the color as uint. The value is in the format 0xAARRGGBB,
  /// where AA represents the alpha channel, RR represents the red channel, GG represents the green channel, and BB represents the blue channel.
  /// </summary>
  public UInt32 ARGB { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Red, green, blue, and alpha components of the color as a tuple of double values between 0 and 1.
  /// </summary>
  public (double R, double G, double B, double A) RGBAComponents { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Hue, saturation, luminance, and alpha components of the color as a tuple of double values between 0 and 1.
  /// </summary>
  public (double H, double S, double L, double A) HSLAComponents { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

}