namespace DocumentModel.Packaging;


/// <summary>
///   Defines the AlternativeFormatImportPart
/// </summary>
/// <para>
///   An alternative format import part allows content specified in an alternate format specified above to be embedded directly in a WordprocessingML document in order to allow that content to be migrated to the WordprocessingML format.
/// </para>
/// <para>
///   Any document part that permits a p element can also contain an altChunk element, whose id attribute refers to a relationship. That relationship shall target a part within the package, which contains the content to be imported into this WordprocessingML document.
/// </para>
public partial class AlternativeFormatImportPart: ModelElement<DXPack.AlternativeFormatImportPart>
{
  public AlternativeFormatImportPart(): base(){ }
  
  public AlternativeFormatImportPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AlternativeFormatImportPart(DXPack.AlternativeFormatImportPart openXmlElement): base(openXmlElement) { }
  
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
