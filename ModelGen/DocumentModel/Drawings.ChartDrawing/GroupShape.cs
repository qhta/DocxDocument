namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Group Shape.
/// </summary>
public partial class GroupShape: ModelElement<DXDCD.GroupShape>
{
  public GroupShape(): base(){ }
  
  public GroupShape(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GroupShape(DXDCD.GroupShape openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Non-Visual Group Shape Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualGroupShapeProperties? NonVisualGroupShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD.NonVisualGroupShapeProperties,DXDCD.NonVisualGroupShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.NonVisualGroupShapeProperties,DXDCD.NonVisualGroupShapeProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Group Shape Properties.
  /// </summary>
  [DataMember]
  public DMDCD.GroupShapeProperties? GroupShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD.GroupShapeProperties,DXDCD.GroupShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.GroupShapeProperties,DXDCD.GroupShapeProperties>(value);
    }
  }
  
}
