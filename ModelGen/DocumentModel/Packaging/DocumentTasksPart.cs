namespace DocumentModel.Packaging;


/// <summary>
///   Defines the DocumentTasksPart
/// </summary>
public partial class DocumentTasksPart: ModelPartElement<DXPack.DocumentTasksPart>
{
  public DocumentTasksPart(): base(){ }
  
  public DocumentTasksPart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public DocumentTasksPart(DXPack.DocumentTasksPart openXmlElement): base(openXmlElement) { }
  
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
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  [DataMember]
  public DM.Tasks? Tasks
  {
    get
    {
        return TasksConverter.CreateModelElement(_Element?.RootElement as DXO21DT.Tasks);
    }
    set
    {
      if (value != null)
      {
         var rootElement = TasksConverter.CreateOpenXmlElement<DXO21DT.Tasks>(value);
         if (rootElement != null)
           _ExistingElement.Tasks = rootElement;
      }
    }
  }
  
}
