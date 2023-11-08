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
      var element = _Element?.GetFirstChild<DXD.GroupShapeLocks>();
      if (element != null)
        return GroupShapeLocksConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.GroupShapeLocks>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GroupShapeLocksConverter.CreateOpenXmlElement<DXD.GroupShapeLocks>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.NonVisualGroupDrawingShapePropsExtensionList>();
      if (element != null)
        return NonVisualGroupDrawingShapePropsExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.NonVisualGroupDrawingShapePropsExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualGroupDrawingShapePropsExtensionListConverter.CreateOpenXmlElement<DXD.NonVisualGroupDrawingShapePropsExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
