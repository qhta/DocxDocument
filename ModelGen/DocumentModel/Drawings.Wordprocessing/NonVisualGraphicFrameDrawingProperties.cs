namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Defines the NonVisualGraphicFrameDrawingProperties Class.
/// </summary>
public partial class NonVisualGraphicFrameDrawingProperties: ModelElement<DXDW.NonVisualGraphicFrameDrawingProperties>
{
  public NonVisualGraphicFrameDrawingProperties(): base(){ }
  
  public NonVisualGraphicFrameDrawingProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualGraphicFrameDrawingProperties(DXDW.NonVisualGraphicFrameDrawingProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Graphic Frame Locks.
  /// </summary>
  [DataMember]
  public DMD.GraphicFrameLocks? GraphicFrameLocks
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.GraphicFrameLocks>();
      if (element != null)
        return GraphicFrameLocksConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.GraphicFrameLocks>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GraphicFrameLocksConverter.CreateOpenXmlElement<DXD.GraphicFrameLocks>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
