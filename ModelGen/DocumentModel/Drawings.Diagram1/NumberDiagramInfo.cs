namespace DocumentModel.Drawings.Diagram1;


/// <summary>
///   Defines the NumberDiagramInfo Class.
/// </summary>
public partial class NumberDiagramInfo: ModelElement<DXO19DD11.NumberDiagramInfo>
{
  public NumberDiagramInfo(): base(){ }
  
  public NumberDiagramInfo(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberDiagramInfo(DXO19DD11.NumberDiagramInfo openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   lvl, this property is only available in Office 2019 and later.
  /// </summary>
  [DataMember]
  public UInt32? Lvl
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   DiagramAutoBullet.
  /// </summary>
  [DataMember]
  public DMDD1.DiagramAutoBullet? DiagramAutoBullet
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
