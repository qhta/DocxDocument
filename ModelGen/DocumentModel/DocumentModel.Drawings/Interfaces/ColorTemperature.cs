namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ColorTemperature Class.
/// </summary>
public interface ColorTemperature
{
  /// <summary>
  /// colorTemp, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? ColorTemperatureValue { get ; set; }
  
}
