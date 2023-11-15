namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Trendline Label.
/// </summary>
public partial class TrendlineLabel: ModelElement<DXDC.TrendlineLabel>
{
  public TrendlineLabel(): base(){ }
  
  public TrendlineLabel(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TrendlineLabel(DXDC.TrendlineLabel openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Layout.
  /// </summary>
  [DataMember]
  public DMDC.Layout? Layout
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   ChartText.
  /// </summary>
  [DataMember]
  public DMDC.ChartText? ChartText
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Number Format.
  /// </summary>
  [DataMember]
  public DMDC.NumberingFormat? NumberingFormat
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  [DataMember]
  public DMDC.ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   TextProperties.
  /// </summary>
  [DataMember]
  public DMDC.TextProperties? TextProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.TextBodyType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.TextBodyType");
  }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  [DataMember]
  public DMDC.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
