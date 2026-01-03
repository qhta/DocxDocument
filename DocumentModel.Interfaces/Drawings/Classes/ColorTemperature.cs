namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ColorTemperature interface.
/// </summary>
public interface ColorTemperature: IModelElement
{
  /// <summary>
  ///   colorTemp, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? ColorTemperatureValue { get; set; }
}