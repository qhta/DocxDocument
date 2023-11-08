namespace DocumentModel.Packaging;


/// <summary>
///   Defines the DiagramStylePart
/// </summary>
public partial class DiagramStylePart: ModelElement<DXPack.DiagramStylePart>
{
  public DiagramStylePart(): base(){ }
  
  public DiagramStylePart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DiagramStylePart(DXPack.DiagramStylePart openXmlElement): base(openXmlElement) { }
  
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
  public DMDD.StyleDefinition? StyleDefinition
  {
    get
    {
        return StyleDefinitionConverter.CreateModelElement(_Element?.RootElement as DXDDD.StyleDefinition);
    }
    set
    {
      if (value != null)
      {
         var rootElement = StyleDefinitionConverter.CreateOpenXmlElement<DXDDD.StyleDefinition>(value);
         if (rootElement != null)
           _ExistingElement.StyleDefinition = rootElement;
      }
    }
  }
  
}
