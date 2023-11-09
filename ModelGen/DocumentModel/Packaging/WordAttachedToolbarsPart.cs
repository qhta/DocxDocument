namespace DocumentModel.Packaging;


/// <summary>
///   Defines the WordAttachedToolbarsPart
/// </summary>
public partial class WordAttachedToolbarsPart: ModelPartElement<DXPack.WordAttachedToolbarsPart>
{
  public WordAttachedToolbarsPart(): base(){ }
  
  public WordAttachedToolbarsPart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public WordAttachedToolbarsPart(DXPack.WordAttachedToolbarsPart openXmlElement): base(openXmlElement) { }
  
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
