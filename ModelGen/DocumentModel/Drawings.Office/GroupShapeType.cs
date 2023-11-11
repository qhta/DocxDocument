namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the GroupShapeType Class.
/// </summary>
public partial class GroupShapeType: ModelElement<DXOD.GroupShapeType>
{
  public GroupShapeType(): base(){ }
  
  public GroupShapeType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GroupShapeType(DXOD.GroupShapeType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   GroupShapeNonVisualProperties.
  /// </summary>
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
  
  
  /// <summary>
  ///   GroupShapeProperties.
  /// </summary>
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
  
}
