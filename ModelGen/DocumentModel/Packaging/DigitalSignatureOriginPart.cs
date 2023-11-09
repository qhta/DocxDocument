namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type is the starting point for navigating through the signatures in a package.
/// </summary>
public partial class DigitalSignatureOriginPart: ModelPartElement<DXPack.DigitalSignatureOriginPart>
{
  public DigitalSignatureOriginPart(): base(){ }
  
  public DigitalSignatureOriginPart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public DigitalSignatureOriginPart(DXPack.DigitalSignatureOriginPart openXmlElement): base(openXmlElement) { }
  
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
