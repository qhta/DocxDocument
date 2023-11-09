namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type contains a given font embedded directly into the document. (This is useful when using custom fonts or fonts that are not widely distributed.)
/// </summary>
public partial class FontPart: ModelPartElement<DXPack.FontPart>
{
  public FontPart(): base(){ }
  
  public FontPart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public FontPart(DXPack.FontPart openXmlElement): base(openXmlElement) { }
  
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
