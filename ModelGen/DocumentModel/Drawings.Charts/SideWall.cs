namespace DocumentModel.Drawings.Charts;


/// <summary>
///   3D side wall formatting.
/// </summary>
public partial class SideWall: ModelElement<DXDC.SideWall>
{
  public SideWall(): base(){ }
  
  public SideWall(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SideWall(DXDC.SideWall openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public Byte? Thickness
  {
    get => _Element?.GetIntVal<Byte, DXDC.Thickness>();
    set => _ExistingElement.SetIntVal<Byte, DXDC.Thickness>(value);
  }
  
  [DataMember]
  public DMDC.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMDC.PictureOptions? PictureOptions
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMDC.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
