namespace DocumentModel.Drawings;

/// <summary>
///   Hue Saturation Luminance Effect.
/// </summary>
public class Hsl: ModelElement
{
  /// <summary>
  ///   Hue
  /// </summary>
  public Int32? Hue { get; set; }

  /// <summary>
  ///   Saturation
  /// </summary>
  public Int32? Saturation { get; set; }

  /// <summary>
  ///   Luminance
  /// </summary>
  public Int32? Luminance { get; set; }
}