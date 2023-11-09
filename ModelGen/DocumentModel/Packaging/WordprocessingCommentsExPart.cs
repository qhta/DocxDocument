namespace DocumentModel.Packaging;


/// <summary>
///   Defines the WordprocessingCommentsExPart
/// </summary>
public partial class WordprocessingCommentsExPart: ModelPartElement<DXPack.WordprocessingCommentsExPart>
{
  public WordprocessingCommentsExPart(): base(){ }
  
  public WordprocessingCommentsExPart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public WordprocessingCommentsExPart(DXPack.WordprocessingCommentsExPart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  [DataMember]
  public DMW13.CommentsEx? CommentsEx
  {
    get
    {
        return CommentsExConverter.CreateModelElement(_Element?.RootElement as DXO13W.CommentsEx);
    }
    set
    {
      if (value != null)
      {
         var rootElement = CommentsExConverter.CreateOpenXmlElement<DXO13W.CommentsEx>(value);
         if (rootElement != null)
           _ExistingElement.CommentsEx = rootElement;
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
