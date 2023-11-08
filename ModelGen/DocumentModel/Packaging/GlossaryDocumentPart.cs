namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type is a supplementary document storage location which stores the definition and content for content that shall be carried with the document for future insertion and/or use, but which shall not be visible within the contents of the main document story.
/// </summary>
public partial class GlossaryDocumentPart: ModelElement<DXPack.GlossaryDocumentPart>
{
  public GlossaryDocumentPart(): base(){ }
  
  public GlossaryDocumentPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GlossaryDocumentPart(DXPack.GlossaryDocumentPart openXmlElement): base(openXmlElement) { }
  
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
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  [DataMember]
  public DMW.GlossaryDocument? GlossaryDocument
  {
    get
    {
        return GlossaryDocumentConverter.CreateModelElement(_Element?.RootElement as DXW.GlossaryDocument);
    }
    set
    {
      if (value != null)
      {
         var rootElement = GlossaryDocumentConverter.CreateOpenXmlElement<DXW.GlossaryDocument>(value);
         if (rootElement != null)
           _ExistingElement.GlossaryDocument = rootElement;
      }
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
