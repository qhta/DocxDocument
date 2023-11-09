namespace DocumentModel.Packaging;


/// <summary>
///   Defines the CustomXmlPart
/// </summary>
public partial class CustomXmlPart: ModelPartElement<DXPack.CustomXmlPart>
{
  public CustomXmlPart(): base(){ }
  
  public CustomXmlPart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public CustomXmlPart(DXPack.CustomXmlPart openXmlElement): base(openXmlElement) { }
  
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
