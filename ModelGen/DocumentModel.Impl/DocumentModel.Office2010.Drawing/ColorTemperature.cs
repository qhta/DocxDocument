namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ColorTemperature Class.
/// </summary>
public class ColorTemperature: IColorTemperature
{
  /// <summary>
  /// colorTemp, this property is only available in Office 2010 and later.
  /// </summary>
  public int? ColorTemperatureValue
  {
    get;
    set;
  }
  
}
