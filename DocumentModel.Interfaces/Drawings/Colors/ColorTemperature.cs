namespace DocumentModel.Drawings;

/// <summary>
/// Defines the color temperature effect for drawing elements.
/// </summary>
public interface ColorTemperature: ExtendableElement
{
  /// <summary>
  /// Color temperature value.
  /// </summary>
  public Int32? ColorTemperatureValue { get; set; }
}