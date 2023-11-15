namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the FullReference Class.
/// </summary>
public partial class FullReference: ModelElement<DXO13DC.FullReference>
{
  public FullReference(): base(){ }
  
  public FullReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FullReference(DXO13DC.FullReference openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   SequenceOfReferences.
  /// </summary>
  [DataMember]
  public DMDC13.SequenceOfReferences? SequenceOfReferences
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
}
