namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type can contain an embedded object produced by any embedded object server.
/// </summary>
public partial class EmbeddedObjectPart: ModelElement<DXPack.EmbeddedObjectPart>
{
  public EmbeddedObjectPart(): base(){ }
  
  public EmbeddedObjectPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EmbeddedObjectPart(DXPack.EmbeddedObjectPart openXmlElement): base(openXmlElement) { }
  
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
