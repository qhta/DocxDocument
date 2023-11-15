namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the GroupShape Class.
/// </summary>
public partial class GroupShape: ModelElement<DXOD.GroupShape>
{
  public GroupShape(): base(){ }
  
  public GroupShape(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GroupShape(DXOD.GroupShape openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDO.GroupShapeNonVisualProperties? GroupShapeNonVisualProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMDO.GroupShapeProperties? GroupShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMDO.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
