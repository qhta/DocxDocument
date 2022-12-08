namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ColorTemperature Class.
/// </summary>
public class ColorTemperatureImpl: ModelElementImpl, ColorTemperature
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ColorTemperature? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ColorTemperature?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// colorTemp, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? ColorTemperatureValue
  {
    get;
    set;
  }
  
}
