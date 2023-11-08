namespace DocumentModel.Packaging;


/// <summary>
///   Defines the WebExTaskpanesPart
/// </summary>
public partial class WebExTaskpanesPart: ModelElement<DXPack.WebExTaskpanesPart>
{
  public WebExTaskpanesPart(): base(){ }
  
  public WebExTaskpanesPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WebExTaskpanesPart(DXPack.WebExTaskpanesPart openXmlElement): base(openXmlElement) { }
  
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
  public DMWEP.Taskpanes? Taskpanes
  {
    get
    {
        return TaskpanesConverter.CreateModelElement(_Element?.RootElement as DXO13WEP.Taskpanes);
    }
    set
    {
      if (value != null)
      {
         var rootElement = TaskpanesConverter.CreateOpenXmlElement<DXO13WEP.Taskpanes>(value);
         if (rootElement != null)
           _ExistingElement.Taskpanes = rootElement;
      }
    }
  }
  
}
