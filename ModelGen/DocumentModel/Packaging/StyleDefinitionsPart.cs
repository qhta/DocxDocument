namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type contains the definition for a set of styles used by this document.
/// </summary>
public partial class StyleDefinitionsPart: ModelElement<DXPack.StyleDefinitionsPart>
{
  public StyleDefinitionsPart(): base(){ }
  
  public StyleDefinitionsPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StyleDefinitionsPart(DXPack.StyleDefinitionsPart openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public String? ContentType
  {
    get
    {
      return _Element?.ContentType;
    }
    set
    {
      _ExistingElement.ContentType = value;
    }
  }
  
  [DataMember]
  public String? RelationshipType
  {
    get
    {
      return _Element?.RelationshipType;
    }
    set
    {
      _ExistingElement.RelationshipType = value;
    }
  }
  
}
