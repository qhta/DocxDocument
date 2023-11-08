namespace DocumentModel.Packaging;


/// <summary>
///   Defines the RibbonExtensibilityPart
/// </summary>
public partial class RibbonExtensibilityPart: ModelElement<DXPack.RibbonExtensibilityPart>
{
  public RibbonExtensibilityPart(): base(){ }
  
  public RibbonExtensibilityPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RibbonExtensibilityPart(DXPack.RibbonExtensibilityPart openXmlElement): base(openXmlElement) { }
  
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
