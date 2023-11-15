namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Relative Anchor Shape Size.
/// </summary>
public partial class RelativeAnchorSize: ModelElement<DXDCD.RelativeAnchorSize>
{
  public RelativeAnchorSize(): base(){ }
  
  public RelativeAnchorSize(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RelativeAnchorSize(DXDCD.RelativeAnchorSize openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Starting Anchor Point.
  /// </summary>
  [DataMember]
  public DMDCD.FromAnchor? FromAnchor
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.ChartDrawing.MarkerType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.ChartDrawing.MarkerType");
  }
  
  
  /// <summary>
  ///   Ending Anchor Point.
  /// </summary>
  [DataMember]
  public DMDCD.ToAnchor? ToAnchor
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.ChartDrawing.MarkerType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.ChartDrawing.MarkerType");
  }
  
  [DataMember]
  public DMDCD.Shape? Shape
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMDCD.GroupShape? GroupShape
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMDCD.GraphicFrame? GraphicFrame
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMDCD.ConnectionShape? ConnectionShape
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMDCD.Picture? Picture
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
