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
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Non-Visual Graphic Frame Drawing Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
