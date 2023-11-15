namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the GroupShapeType Class.
/// </summary>
public partial class GroupShapeType: ModelElement<DXOD.GroupShapeType>
{
  public GroupShapeType(): base(){ }
  
  public GroupShapeType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GroupShapeType(DXOD.GroupShapeType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   GroupShapeNonVisualProperties.
  /// </summary>
  [DataMember]
  public DMDO.GroupShapeNonVisualProperties? GroupShapeNonVisualProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   GroupShapeProperties.
  /// </summary>
  [DataMember]
  public DMDO.GroupShapeProperties? GroupShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
