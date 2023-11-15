namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Graphic Frame.
/// </summary>
public partial class GraphicFrame: ModelElement<DXDCD.GraphicFrame>
{
  public GraphicFrame(): base(){ }
  
  public GraphicFrame(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GraphicFrame(DXDCD.GraphicFrame openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Reference to Custom Function
  /// </summary>
  [DataMember]
  public String? Macro
  {
    get => _Element?.Macro;
    set => _ExistingElement.Macro = value;
  }
  
  
  /// <summary>
  ///   Publish To Server
  /// </summary>
  [DataMember]
  public Boolean? Published
  {
    get => _Element?.Published?.Value;
    set => _ExistingElement.Published = value;
  }
  
  
  /// <summary>
  ///   Non-Visual Graphic Frame Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Graphic Frame Transform.
  /// </summary>
  [DataMember]
  public DMDCD.Transform? Transform
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Graphical Object.
  /// </summary>
  [DataMember]
  public DMD.Graphic? Graphic
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
