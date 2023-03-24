namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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