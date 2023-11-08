namespace DocumentModel.Packaging;


/// <summary>
///   Defines the DiagramColorsPart
/// </summary>
public partial class DiagramColorsPart: ModelElement<DXPack.DiagramColorsPart>
{
  public DiagramColorsPart(): base(){ }
  
  public DiagramColorsPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DiagramColorsPart(DXPack.DiagramColorsPart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  [DataMember]
  public DMDD.ColorsDefinition? ColorsDefinition
  {
    get
    {
        return ColorsDefinitionConverter.CreateModelElement(_Element?.RootElement as DXDDD.ColorsDefinition);
    }
    set
    {
      if (value != null)
      {
         var rootElement = ColorsDefinitionConverter.CreateOpenXmlElement<DXDDD.ColorsDefinition>(value);
         if (rootElement != null)
           _ExistingElement.ColorsDefinition = rootElement;
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
