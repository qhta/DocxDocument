namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Non-Visual Graphic Frame Drawing Properties.
/// </summary>
public partial class NonVisualGraphicFrameDrawingProperties: ModelElement<DXDCD.NonVisualGraphicFrameDrawingProperties>
{
  public NonVisualGraphicFrameDrawingProperties(): base(){ }
  
  public NonVisualGraphicFrameDrawingProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualGraphicFrameDrawingProperties(DXDCD.NonVisualGraphicFrameDrawingProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Graphic Frame Locks.
  /// </summary>
  [DataMember]
  public DMD.GraphicFrameLocks? GraphicFrameLocks
  {
    get
    {
      return _Element?.GetObject<DMD.GraphicFrameLocks,DXD.GraphicFrameLocks>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.GraphicFrameLocks,DXD.GraphicFrameLocks>(value);
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
      return _Element?.GetObject<DMD.ExtensionList,DXD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ExtensionList,DXD.ExtensionList>(value);
    }
  }
  
}
