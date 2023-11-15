namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ColorTemperature Class.
/// </summary>
public partial class ColorTemperature: ModelElement<DXO10D.ColorTemperature>
{
  public ColorTemperature(): base(){ }
  
  public ColorTemperature(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorTemperature(DXO10D.ColorTemperature openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   colorTemp, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? ColorTemperatureValue
  {
    get => _Element?.ColorTemperatureValue?.Value;
    set => _ExistingElement.ColorTemperatureValue = value;
  }
  
}
