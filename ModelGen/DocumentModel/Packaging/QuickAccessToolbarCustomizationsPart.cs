namespace DocumentModel.Packaging;


/// <summary>
///   Defines the QuickAccessToolbarCustomizationsPart
/// </summary>
public partial class QuickAccessToolbarCustomizationsPart: ModelPartElement<DXPack.QuickAccessToolbarCustomizationsPart>
{
  public QuickAccessToolbarCustomizationsPart(): base(){ }
  
  public QuickAccessToolbarCustomizationsPart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public QuickAccessToolbarCustomizationsPart(DXPack.QuickAccessToolbarCustomizationsPart openXmlElement): base(openXmlElement) { }
  
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
