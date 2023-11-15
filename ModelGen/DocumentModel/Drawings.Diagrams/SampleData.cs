namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Defines the SampleData Class.
/// </summary>
public partial class SampleData: ModelElement<DXDDD.SampleData>
{
  public SampleData(): base(){ }
  
  public SampleData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SampleData(DXDDD.SampleData openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDD.DataModel? DataModel
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
