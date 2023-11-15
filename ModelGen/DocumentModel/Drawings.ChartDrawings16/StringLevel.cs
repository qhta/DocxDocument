namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the StringLevel Class.
/// </summary>
public partial class StringLevel: ModelElement<DXO16DCD.StringLevel>
{
  public StringLevel(): base(){ }
  
  public StringLevel(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StringLevel(DXO16DCD.StringLevel openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ptCount, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public UInt32? PtCount
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   name, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? Name
  {
    get => _Element?.Name;
    set => _ExistingElement.Name = value;
  }
  
}
