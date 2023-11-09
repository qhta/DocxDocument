namespace DocumentModel.Packaging;


/// <summary>
///   Defines the XmlSignaturePart
/// </summary>
public partial class XmlSignaturePart: ModelPartElement<DXPack.XmlSignaturePart>
{
  public XmlSignaturePart(): base(){ }
  
  public XmlSignaturePart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public XmlSignaturePart(DXPack.XmlSignaturePart openXmlElement): base(openXmlElement) { }
  
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
