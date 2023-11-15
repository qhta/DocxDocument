namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the ShapeTree Class.
/// </summary>
public partial class ShapeTree: ModelElement<DXOD.ShapeTree>
{
  public ShapeTree(): base(){ }
  
  public ShapeTree(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShapeTree(DXOD.ShapeTree openXmlElement): base(openXmlElement) { }
  
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
