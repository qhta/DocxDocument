namespace DocumentModel.Packaging;


/// <summary>
///   Defines the WordprocessingCommentsPart
/// </summary>
public partial class WordprocessingCommentsPart: ModelPartElement<DXPack.WordprocessingCommentsPart>
{
  public WordprocessingCommentsPart(): base(){ }
  
  public WordprocessingCommentsPart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public WordprocessingCommentsPart(DXPack.WordprocessingCommentsPart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  [DataMember]
  public DMW.Comments? Comments
  {
    get
    {
        return CommentsConverter.CreateModelElement(_Element?.RootElement as DXW.Comments);
    }
    set
    {
      if (value != null)
      {
         var rootElement = CommentsConverter.CreateOpenXmlElement<DXW.Comments>(value);
         if (rootElement != null)
           _ExistingElement.Comments = rootElement;
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
