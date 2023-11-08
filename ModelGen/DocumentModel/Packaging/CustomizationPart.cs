namespace DocumentModel.Packaging;


/// <summary>
///   Defines the CustomizationPart
/// </summary>
public partial class CustomizationPart: ModelElement<DXPack.CustomizationPart>
{
  public CustomizationPart(): base(){ }
  
  public CustomizationPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
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
