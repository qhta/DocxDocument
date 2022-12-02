namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ColorTemperature Class.
/// </summary>
public interface IColorTemperature // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// colorTemp, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? ColorTemperatureValue { get ; set; }
  
}
