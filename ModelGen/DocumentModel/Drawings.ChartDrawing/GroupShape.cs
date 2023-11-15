namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Group Shape.
/// </summary>
public partial class GroupShape: ModelElement<DXDCD.GroupShape>
{
  public GroupShape(): base(){ }
  
  public GroupShape(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GroupShape(DXDCD.GroupShape openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Non-Visual Group Shape Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualGroupShapeProperties? NonVisualGroupShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Group Shape Properties.
  /// </summary>
  [DataMember]
  public DMDCD.GroupShapeProperties? GroupShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
