namespace DocumentModel.Packaging;


/// <summary>
///   Defines the CustomizationPart
/// </summary>
public partial class CustomizationPart: ModelPartElement<DXPack.CustomizationPart>
{
  public CustomizationPart(): base(){ }
  
  public CustomizationPart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public CustomizationPart(DXPack.CustomizationPart openXmlElement): base(openXmlElement) { }
  
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
