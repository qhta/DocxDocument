namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Defines the StyleData Class.
/// </summary>
public partial class StyleData: ModelElement<DXDDD.StyleData>
{
  public StyleData(): base(){ }
  
  public StyleData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StyleData(DXDDD.StyleData openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDD.DataModel? DataModel
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
