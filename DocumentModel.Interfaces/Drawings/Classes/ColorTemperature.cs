namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ColorTemperature interface.
/// </summary>
public interface ColorTemperature: IModelElement
{
  /// <summary>
  ///   colorTemp
  /// </summary>
  public Int32? ColorTemperatureValue { get; set; }
}