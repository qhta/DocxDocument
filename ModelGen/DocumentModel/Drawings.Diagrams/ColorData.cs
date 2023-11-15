namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Defines the ColorData Class.
/// </summary>
public partial class ColorData: ModelElement<DXDDD.ColorData>
{
  public ColorData(): base(){ }
  
  public ColorData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorData(DXDDD.ColorData openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDD.DataModel? DataModel
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
