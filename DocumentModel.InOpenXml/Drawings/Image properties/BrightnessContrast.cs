namespace DocumentModel.Drawings;

/// <summary>
/// Represents brightness and contrast adjustment settings for a drawing element.
/// </summary>
public interface BrightnessContrast: IExtendableElement
{
  /// <summary>
  /// Brightness adjustment value.
  /// </summary>
  public Int32? Bright { get; set; }

  /// <summary>
  /// Contrast adjustment value.
  /// </summary>
  public Int32? Contrast { get; set; }
}