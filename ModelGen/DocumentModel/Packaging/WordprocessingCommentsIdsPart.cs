namespace DocumentModel.Packaging;


/// <summary>
///   Defines the WordprocessingCommentsIdsPart
/// </summary>
public partial class WordprocessingCommentsIdsPart: ModelElement<DXPack.WordprocessingCommentsIdsPart>
{
  public WordprocessingCommentsIdsPart(): base(){ }
  
  public WordprocessingCommentsIdsPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WordprocessingCommentsIdsPart(DXPack.WordprocessingCommentsIdsPart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  [DataMember]
  public DMW.CommentsIds? CommentsIds
  {
    get
    {
        return CommentsIdsConverter.CreateModelElement(_Element?.RootElement as DXO19WC.CommentsIds);
    }
    set
    {
      if (value != null)
      {
         var rootElement = CommentsIdsConverter.CreateOpenXmlElement<DXO19WC.CommentsIds>(value);
         if (rootElement != null)
           _ExistingElement.CommentsIds = rootElement;
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
