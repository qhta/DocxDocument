namespace DocumentModel.Packaging;


/// <summary>
///   Defines the Model3DReferenceRelationshipPart
/// </summary>
public partial class Model3DReferenceRelationshipPart: ModelElement<DXPack.Model3DReferenceRelationshipPart>
{
  public Model3DReferenceRelationshipPart(): base(){ }
  
  public Model3DReferenceRelationshipPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Model3DReferenceRelationshipPart(DXPack.Model3DReferenceRelationshipPart openXmlElement): base(openXmlElement) { }
  
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
