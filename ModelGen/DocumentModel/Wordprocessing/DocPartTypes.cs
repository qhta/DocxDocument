namespace DocumentModel.Wordprocessing;


/// <summary>
///   Entry Types.
/// </summary>
public partial class DocPartTypes: ModelElement<DXW.DocPartTypes>
{
  public DocPartTypes(): base(){ }
  
  public DocPartTypes(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocPartTypes(DXW.DocPartTypes openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Entry Is Of All Types
  /// </summary>
  [DataMember]
  public Boolean? All
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  [DataMember]
  public DM.ElementCollection<DocPartKind>? Items
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentModel.ModelElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentModel.ModelElement");
  }
  
}
