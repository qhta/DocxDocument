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
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
