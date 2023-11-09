namespace DocumentModel.Packaging;


/// <summary>
///   Defines the WordprocessingPeoplePart
/// </summary>
public partial class WordprocessingPeoplePart: ModelPartElement<DXPack.WordprocessingPeoplePart>
{
  public WordprocessingPeoplePart(): base(){ }
  
  public WordprocessingPeoplePart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public WordprocessingPeoplePart(DXPack.WordprocessingPeoplePart openXmlElement): base(openXmlElement) { }
  
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
  public DMW13.People? People
  {
    get
    {
        return PeopleConverter.CreateModelElement(_Element?.RootElement as DXO13W.People);
    }
    set
    {
      if (value != null)
      {
         var rootElement = PeopleConverter.CreateOpenXmlElement<DXO13W.People>(value);
         if (rootElement != null)
           _ExistingElement.People = rootElement;
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
