namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the Trendline Class.
/// </summary>
public partial class Trendline: ModelElement<DXDC.Trendline>
{
  public Trendline(): base(){ }
  
  public Trendline(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Trendline(DXDC.Trendline openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Trendline Name.
  /// </summary>
  [DataMember]
  public DMDC.TrendlineName? TrendlineName
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
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
  ///   Trendline Type.
  /// </summary>
  [DataMember]
  public DMDC.TrendlineKind? TrendlineType
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Polynomial Trendline Order.
  /// </summary>
  [DataMember]
  public Byte? PolynomialOrder
  {
    get => _Element?.GetIntVal<Byte, DXDC.PolynomialOrder>();
    set => _ExistingElement.SetIntVal<Byte, DXDC.PolynomialOrder>(value);
  }
  
  
  /// <summary>
  ///   Period.
  /// </summary>
  [DataMember]
  public UInt32? Period
  {
    get => _Element?.GetIntVal<UInt32, DXDC.Period>();
    set => _ExistingElement.SetIntVal<UInt32, DXDC.Period>(value);
  }
  
  
  /// <summary>
  ///   Forward.
  /// </summary>
  [DataMember]
  public DMDC.Forward? Forward
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.DoubleType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.DoubleType");
  }
  
  
  /// <summary>
  ///   Backward.
  /// </summary>
  [DataMember]
  public DMDC.Backward? Backward
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.DoubleType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.DoubleType");
  }
  
  
  /// <summary>
  ///   Intercept.
  /// </summary>
  [DataMember]
  public DMDC.Intercept? Intercept
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.DoubleType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.DoubleType");
  }
  
  
  /// <summary>
  ///   Display R Squared Value.
  /// </summary>
  [DataMember]
  public DMDC.DisplayRSquaredValue? DisplayRSquaredValue
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
  }
  
  
  /// <summary>
  ///   Display Equation.
  /// </summary>
  [DataMember]
  public DMDC.DisplayEquation? DisplayEquation
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
  }
  
  
  /// <summary>
  ///   Trendline Label.
  /// </summary>
  [DataMember]
  public DMDC.TrendlineLabel? TrendlineLabel
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
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
