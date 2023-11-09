namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type contains the body of the document.
/// </summary>
public partial class MainDocumentPart: ModelPartElement<DXPack.MainDocumentPart>
{
  public MainDocumentPart(): base(){ }
  
  public MainDocumentPart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public MainDocumentPart(DXPack.MainDocumentPart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  [DataMember]
  public DMW.Document? Document
  {
    get
    {
        return DocumentConverter.CreateModelElement(_Element?.RootElement as DXW.Document);
    }
    set
    {
      if (value != null)
      {
         var rootElement = DocumentConverter.CreateOpenXmlElement<DXW.Document>(value);
         if (rootElement != null)
           _ExistingElement.Document = rootElement;
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
