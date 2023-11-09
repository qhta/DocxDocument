namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type contains a complete package. For example, a WordprocessingML document might contain a SpreadsheetML or PresentationML document, in which case, the WordprocessingML document package would contain an embedded package part that defined that SpreadsheetML or PresentationML document.
/// </summary>
public partial class EmbeddedPackagePart: ModelPartElement<DXPack.EmbeddedPackagePart>
{
  public EmbeddedPackagePart(): base(){ }
  
  public EmbeddedPackagePart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public EmbeddedPackagePart(DXPack.EmbeddedPackagePart openXmlElement): base(openXmlElement) { }
  
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
