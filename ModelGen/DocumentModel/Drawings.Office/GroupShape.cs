namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the GroupShape Class.
/// </summary>
public partial class GroupShape: ModelElement<DXOD.GroupShape>
{
  public GroupShape(): base(){ }
  
  public GroupShape(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GroupShape(DXOD.GroupShape openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDO.GroupShapeNonVisualProperties? GroupShapeNonVisualProperties
  {
    get
    {
      return _Element?.GetObject<DMDO.GroupShapeNonVisualProperties,DXOD.GroupShapeNonVisualProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDO.GroupShapeNonVisualProperties,DXOD.GroupShapeNonVisualProperties>(value);
    }
  }
  
  [DataMember]
  public DMDO.GroupShapeProperties? GroupShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMDO.GroupShapeProperties,DXOD.GroupShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDO.GroupShapeProperties,DXOD.GroupShapeProperties>(value);
    }
  }
  
  [DataMember]
  public DMDO.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDO.OfficeArtExtensionList,DXOD.OfficeArtExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDO.OfficeArtExtensionList,DXOD.OfficeArtExtensionList>(value);
    }
  }
  
}
