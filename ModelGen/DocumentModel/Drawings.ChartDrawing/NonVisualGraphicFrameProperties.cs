namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Non-Visual Graphic Frame Properties.
/// </summary>
public partial class NonVisualGraphicFrameProperties: ModelElement<DXDCD.NonVisualGraphicFrameProperties>
{
  public NonVisualGraphicFrameProperties(): base(){ }
  
  public NonVisualGraphicFrameProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualGraphicFrameProperties(DXDCD.NonVisualGraphicFrameProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Non-Visual Drawing Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD.NonVisualDrawingProperties,DXDCD.NonVisualDrawingProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.NonVisualDrawingProperties,DXDCD.NonVisualDrawingProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Non-Visual Graphic Frame Drawing Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD.NonVisualGraphicFrameDrawingProperties,DXDCD.NonVisualGraphicFrameDrawingProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.NonVisualGraphicFrameDrawingProperties,DXDCD.NonVisualGraphicFrameDrawingProperties>(value);
    }
  }
  
}
