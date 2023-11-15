namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the LevelReference Class.
/// </summary>
public partial class LevelReference: ModelElement<DXO13DC.LevelReference>
{
  public LevelReference(): base(){ }
  
  public LevelReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LevelReference(DXO13DC.LevelReference openXmlElement): base(openXmlElement) { }
  
  
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
