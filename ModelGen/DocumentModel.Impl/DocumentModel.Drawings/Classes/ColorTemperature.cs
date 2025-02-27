namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ColorTemperature Class.
/// </summary>
public partial class ColorTemperatureImpl: ModelElementImpl, ColorTemperature
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Drawing.ColorTemperature? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ColorTemperature?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ColorTemperatureImpl(): base() {}
  
  public ColorTemperatureImpl(DocumentFormat.OpenXml.Office2010.Drawing.ColorTemperature openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// colorTemp, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? ColorTemperatureValue
  {
    get => (System.Int32?)OpenXmlElement?.ColorTemperatureValue?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ColorTemperatureValue = (System.Int32?)value;
    }
  }
  
}
