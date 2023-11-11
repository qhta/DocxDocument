namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Non-Visual Group Shape Drawing Properties.
/// </summary>
public partial class NonVisualGroupShapeDrawingProperties: ModelElement<DXDCD.NonVisualGroupShapeDrawingProperties>
{
  public NonVisualGroupShapeDrawingProperties(): base(){ }
  
  public NonVisualGroupShapeDrawingProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualGroupShapeDrawingProperties(DXDCD.NonVisualGroupShapeDrawingProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   GroupShapeLocks.
  /// </summary>
  [DataMember]
  public DMD.GroupShapeLocks? GroupShapeLocks
  {
    get
    {
      return _Element?.GetObject<DMD.GroupShapeLocks,DXD.GroupShapeLocks>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.GroupShapeLocks,DXD.GroupShapeLocks>(value);
    }
  }
  
  
  /// <summary>
  ///   NonVisualGroupDrawingShapePropsExtensionList.
  /// </summary>
  [DataMember]
  public DMD.NonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList
  {
    get
    {
      return _Element?.GetObject<DMD.NonVisualGroupDrawingShapePropsExtensionList,DXD.NonVisualGroupDrawingShapePropsExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.NonVisualGroupDrawingShapePropsExtensionList,DXD.NonVisualGroupDrawingShapePropsExtensionList>(value);
    }
  }
  
}
