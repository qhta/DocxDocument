namespace DocumentModel.Drawings;

/// <summary>
/// Defines the color temperature effect for drawing elements.
/// </summary>
public class ColorTemperature: ModelElement<DXO10D.ColorTemperature>, IExtendableElement
{
  /// <summary>
  /// Color temperature value.
  /// </summary>
  public Int32? ColorTemperatureValue { get; set; }

  /// <summary>
  /// List of extensions for the color temperature effect.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}