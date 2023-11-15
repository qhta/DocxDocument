namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the GroupShapeNonVisualProperties Class.
/// </summary>
public partial class GroupShapeNonVisualProperties: ModelElement<DXOD.GroupShapeNonVisualProperties>
{
  public GroupShapeNonVisualProperties(): base(){ }
  
  public GroupShapeNonVisualProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GroupShapeNonVisualProperties(DXOD.GroupShapeNonVisualProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   NonVisualDrawingProperties.
  /// </summary>
  [DataMember]
  public DMDO.NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   NonVisualGroupDrawingShapeProperties.
  /// </summary>
  [DataMember]
  public DMDO.NonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
