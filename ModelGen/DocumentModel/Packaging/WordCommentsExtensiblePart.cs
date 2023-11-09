namespace DocumentModel.Packaging;


/// <summary>
///   Defines the WordCommentsExtensiblePart
/// </summary>
public partial class WordCommentsExtensiblePart: ModelPartElement<DXPack.WordCommentsExtensiblePart>
{
  public WordCommentsExtensiblePart(): base(){ }
  
  public WordCommentsExtensiblePart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public WordCommentsExtensiblePart(DXPack.WordCommentsExtensiblePart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  [DataMember]
  public DMW.CommentsExtensible? CommentsExtensible
  {
    get
    {
        return CommentsExtensibleConverter.CreateModelElement(_Element?.RootElement as DXO21WCE.CommentsExtensible);
    }
    set
    {
      if (value != null)
      {
         var rootElement = CommentsExtensibleConverter.CreateOpenXmlElement<DXO21WCE.CommentsExtensible>(value);
         if (rootElement != null)
           _ExistingElement.CommentsExtensible = rootElement;
      }
    }
  }
  
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
