namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Luminance.
/// </summary>
public class LuminanceEffect: ModelElement
{
  /// <summary>
  ///   Brightness
  /// </summary>
  public Int32? Brightness { get; set; }

  /// <summary>
  ///   Contrast
  /// </summary>
  public Int32? Contrast { get; set; }
}