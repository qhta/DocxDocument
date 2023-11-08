namespace DocumentModel.Packaging;


/// <summary>
///   An image can be stored in a package as a ZIP item. Image ZIP items shall be identified by an image part relationship and the appropriate content type.
/// </summary>
public partial class ImagePart: ModelElement<DXPack.ImagePart>
{
  public ImagePart(): base(){ }
  
  public ImagePart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ImagePart(DXPack.ImagePart openXmlElement): base(openXmlElement) { }
  
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
