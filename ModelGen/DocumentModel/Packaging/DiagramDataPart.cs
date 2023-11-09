namespace DocumentModel.Packaging;


/// <summary>
///   Defines the DiagramDataPart
/// </summary>
public partial class DiagramDataPart: ModelPartElement<DXPack.DiagramDataPart>
{
  public DiagramDataPart(): base(){ }
  
  public DiagramDataPart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public DiagramDataPart(DXPack.DiagramDataPart openXmlElement): base(openXmlElement) { }
  
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
  public DMDD.DataModelRoot? DataModelRoot
  {
    get
    {
        return DataModelRootConverter.CreateModelElement(_Element?.RootElement as DXDDD.DataModelRoot);
    }
    set
    {
      if (value != null)
      {
         var rootElement = DataModelRootConverter.CreateOpenXmlElement<DXDDD.DataModelRoot>(value);
         if (rootElement != null)
           _ExistingElement.DataModelRoot = rootElement;
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
