namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the NonVisualGroupDrawingShapeProperties Class.
/// </summary>
public partial class NonVisualGroupDrawingShapeProperties: ModelElement<DXOD.NonVisualGroupDrawingShapeProperties>
{
  public NonVisualGroupDrawingShapeProperties(): base(){ }
  
  public NonVisualGroupDrawingShapeProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualGroupDrawingShapeProperties(DXOD.NonVisualGroupDrawingShapeProperties openXmlElement): base(openXmlElement) { }
  
  
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
