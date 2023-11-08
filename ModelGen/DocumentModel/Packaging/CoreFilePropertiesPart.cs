namespace DocumentModel.Packaging;


/// <summary>
///   Core properties enable users to get and set well-known and common sets of property metadata within packages.
/// </summary>
public partial class CoreFilePropertiesPart: ModelElement<DXPack.CoreFilePropertiesPart>
{
  public CoreFilePropertiesPart(): base(){ }
  
  public CoreFilePropertiesPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CoreFilePropertiesPart(DXPack.CoreFilePropertiesPart openXmlElement): base(openXmlElement) { }
  
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
