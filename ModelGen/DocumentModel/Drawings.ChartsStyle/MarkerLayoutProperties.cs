namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the MarkerLayoutProperties Class.
/// </summary>
public partial class MarkerLayoutProperties: ModelElement<DXO13DCS.MarkerLayoutProperties>
{
  public MarkerLayoutProperties(): base(){ }
  
  public MarkerLayoutProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MarkerLayoutProperties(DXO13DCS.MarkerLayoutProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   size, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public Byte? Size
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Byte]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Byte]");
  }
  
}
