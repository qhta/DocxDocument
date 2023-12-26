namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the ColorStyle Class.
/// </summary>
public partial class ColorStyle: ModelElement<DXO13DCS.ColorStyle>
{
  public ColorStyle(): base(){ }
  
  public ColorStyle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorStyle(DXO13DCS.ColorStyle openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   meth, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? Method
  {
    get => _Element?.Method;
    set => _ExistingElement.Method = value;
  }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public UInt32? Id
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
}
