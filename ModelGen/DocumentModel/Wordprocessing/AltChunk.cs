namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the AltChunk Class.
/// </summary>
public partial class AltChunk: ModelElement<DXW.AltChunk>
{
  public AltChunk(): base(){ }
  
  public AltChunk(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AltChunk(DXW.AltChunk openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Relationship to Part
  /// </summary>
  [DataMember]
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
  }
  
  
  /// <summary>
  ///   External Content Import Properties.
  /// </summary>
  [DataMember]
  public DMW.AltChunkProperties? AltChunkProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
