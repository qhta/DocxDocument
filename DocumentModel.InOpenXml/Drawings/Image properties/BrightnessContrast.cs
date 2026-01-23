namespace DocumentModel.Drawings;

/// <summary>
/// Represents brightness and contrast adjustment settings for a drawing element.
/// </summary>
public class BrightnessContrast: ModelElement<DXO10D.BrightnessContrast>, IExtendableElement
{
  /// <summary>
  /// Brightness adjustment value.
  /// </summary>
  public Int32? Bright { get; set; }

  /// <summary>
  /// Contrast adjustment value.
  /// </summary>
  public Int32? Contrast { get; set; }

  /// <summary>
  /// List of extensions for additional brightness and contrast settings.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}