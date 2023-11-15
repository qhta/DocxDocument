namespace DocumentModel.Drawings.Charts;


/// <summary>
///   3D back wall formatting.
/// </summary>
public partial class BackWall: ModelElement<DXDC.BackWall>
{
  public BackWall(): base(){ }
  
  public BackWall(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BackWall(DXDC.BackWall openXmlElement): base(openXmlElement) { }
  
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
