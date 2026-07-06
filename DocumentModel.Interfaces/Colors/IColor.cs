namespace DocumentModel;

/// <summary>
/// Full color interface, supporting both RGB and theme colors.
/// </summary>
public interface IColor
{
  /// <summary>A value of the color as uint. The value is in the format 0xRRGGBB,
  /// where RR represents the red channel, GG represents the green channel, and BB represents the blue channel.
  /// </summary>
  public UInt32? RGB { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Red, green, and blue components of the color as a tuple of double values between 0 and 1.
  /// </summary>
  public (double R, double G, double B) RGBComponents { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }


  /// <summary>
  /// Hue, saturation, and luminance components of the color as a tuple of double values between 0 and 1.
  /// </summary>
  public (double H, double S, double L) HSLComponents { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the name of color. May be used to specify a color by name, such as "red", "blue", etc.
  /// The actual interpretation of the name depends on the context in which it is used and may be mapped to a specific RGB value or theme color.
  /// </summary>
  public string? Name { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

}