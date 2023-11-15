namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Defines the SampleDataType Class.
/// </summary>
public partial class SampleDataType: ModelElement<DXDDD.SampleDataType>
{
  public SampleDataType(): base(){ }
  
  public SampleDataType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SampleDataType(DXDDD.SampleDataType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Use Default
  /// </summary>
  [DataMember]
  public Boolean? UseDefault
  {
    get => _Element?.UseDefault?.Value;
    set => _ExistingElement.UseDefault = value;
  }
  
  
  /// <summary>
  ///   Data Model.
  /// </summary>
  [DataMember]
  public DMDD.DataModel? DataModel
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
