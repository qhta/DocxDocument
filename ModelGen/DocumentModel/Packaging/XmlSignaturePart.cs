namespace DocumentModel.Packaging;


/// <summary>
///   Defines the XmlSignaturePart
/// </summary>
public partial class XmlSignaturePart: ModelElement<DXPack.XmlSignaturePart>
{
  public XmlSignaturePart(): base(){ }
  
  public XmlSignaturePart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
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
