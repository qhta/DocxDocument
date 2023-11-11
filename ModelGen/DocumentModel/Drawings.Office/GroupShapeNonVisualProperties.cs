namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the GroupShapeNonVisualProperties Class.
/// </summary>
public partial class GroupShapeNonVisualProperties: ModelElement<DXOD.GroupShapeNonVisualProperties>
{
  public GroupShapeNonVisualProperties(): base(){ }
  
  public GroupShapeNonVisualProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GroupShapeNonVisualProperties(DXOD.GroupShapeNonVisualProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   NonVisualDrawingProperties.
  /// </summary>
  [DataMember]
  public DMDO.NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get
    {
      return _Element?.GetObject<DMDO.NonVisualDrawingProperties,DXOD.NonVisualDrawingProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDO.NonVisualDrawingProperties,DXOD.NonVisualDrawingProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   NonVisualGroupDrawingShapeProperties.
  /// </summary>
  [DataMember]
  public DMDO.NonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMDO.NonVisualGroupDrawingShapeProperties,DXOD.NonVisualGroupDrawingShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDO.NonVisualGroupDrawingShapeProperties,DXOD.NonVisualGroupDrawingShapeProperties>(value);
    }
  }
  
}
