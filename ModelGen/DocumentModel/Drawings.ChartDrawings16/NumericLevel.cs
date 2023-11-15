namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the NumericLevel Class.
/// </summary>
public partial class NumericLevel: ModelElement<DXO16DCD.NumericLevel>
{
  public NumericLevel(): base(){ }
  
  public NumericLevel(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumericLevel(DXO16DCD.NumericLevel openXmlElement): base(openXmlElement) { }
  
  
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
  ///   formatCode, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? FormatCode
  {
    get => _Element?.FormatCode;
    set => _ExistingElement.FormatCode = value;
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
  
  [DataMember]
  public DM.ElementCollection<NumericValue>? Items
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentModel.ModelElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentModel.ModelElement");
  }
  
}
