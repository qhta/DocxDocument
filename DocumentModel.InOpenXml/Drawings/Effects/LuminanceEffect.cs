namespace DocumentModel.Drawings;

/// <summary>
///   Represents a luminance effect, allowing adjustment of brightness and contrast for a drawing element.
/// </summary>
public interface LuminanceEffect
{
  /// <summary>
  ///   Brightness adjustment value.
  /// </summary>
  public Int32? Brightness { get; set; }

  /// <summary>
  ///   Contrast adjustment value.
  /// </summary>
  public Int32? Contrast { get; set; }
}