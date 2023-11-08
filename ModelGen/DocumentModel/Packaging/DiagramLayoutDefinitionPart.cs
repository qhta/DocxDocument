namespace DocumentModel.Packaging;


/// <summary>
///   Defines the DiagramLayoutDefinitionPart
/// </summary>
public partial class DiagramLayoutDefinitionPart: ModelElement<DXPack.DiagramLayoutDefinitionPart>
{
  public DiagramLayoutDefinitionPart(): base(){ }
  
  public DiagramLayoutDefinitionPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DiagramLayoutDefinitionPart(DXPack.DiagramLayoutDefinitionPart openXmlElement): base(openXmlElement) { }
  
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
  public DMDD.LayoutDefinition? LayoutDefinition
  {
    get
    {
        return LayoutDefinitionConverter.CreateModelElement(_Element?.RootElement as DXDDD.LayoutDefinition);
    }
    set
    {
      if (value != null)
      {
         var rootElement = LayoutDefinitionConverter.CreateOpenXmlElement<DXDDD.LayoutDefinition>(value);
         if (rootElement != null)
           _ExistingElement.LayoutDefinition = rootElement;
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
