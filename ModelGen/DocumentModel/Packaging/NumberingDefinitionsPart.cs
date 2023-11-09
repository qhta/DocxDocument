namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type contains a definition for the structure of each unique numbering definition in this document.
/// </summary>
public partial class NumberingDefinitionsPart: ModelPartElement<DXPack.NumberingDefinitionsPart>
{
  public NumberingDefinitionsPart(): base(){ }
  
  public NumberingDefinitionsPart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public NumberingDefinitionsPart(DXPack.NumberingDefinitionsPart openXmlElement): base(openXmlElement) { }
  
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
  public DMW.Numbering? Numbering
  {
    get
    {
        return NumberingConverter.CreateModelElement(_Element?.RootElement as DXW.Numbering);
    }
    set
    {
      if (value != null)
      {
         var rootElement = NumberingConverter.CreateOpenXmlElement<DXW.Numbering>(value);
         if (rootElement != null)
           _ExistingElement.Numbering = rootElement;
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
