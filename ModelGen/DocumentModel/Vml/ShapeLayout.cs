namespace DocumentModel.Vml;


/// <summary>
///   Shape Layout Properties.
/// </summary>
public partial class ShapeLayout: ModelElement<DXVO.ShapeLayout>
{
  public ShapeLayout(): base(){ }
  
  public ShapeLayout(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShapeLayout(DXVO.ShapeLayout openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Shape ID Map.
  /// </summary>
  [DataMember]
  public DMVML.ShapeIdMap? ShapeIdMap
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Shape Grouping History.
  /// </summary>
  [DataMember]
  public DMVML.RegroupTable? RegroupTable
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Rule Set.
  /// </summary>
  [DataMember]
  public DMVML.Rules? Rules
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
