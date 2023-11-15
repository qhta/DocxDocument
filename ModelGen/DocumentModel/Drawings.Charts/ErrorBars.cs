namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ErrorBars Class.
/// </summary>
public partial class ErrorBars: ModelElement<DXDC.ErrorBars>
{
  public ErrorBars(): base(){ }
  
  public ErrorBars(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ErrorBars(DXDC.ErrorBars openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Error Bar Direction.
  /// </summary>
  [DataMember]
  public DMDC.ErrorBarDirectionKind? ErrorDirection
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Error Bar Type.
  /// </summary>
  [DataMember]
  public DMDC.ErrorBarKind? ErrorBarType
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Error Bar Value Type.
  /// </summary>
  [DataMember]
  public DMDC.ErrorKind? ErrorBarValueType
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   No End Cap.
  /// </summary>
  [DataMember]
  public DMDC.NoEndCap? NoEndCap
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
  }
  
  
  /// <summary>
  ///   Plus.
  /// </summary>
  [DataMember]
  public DMDC.Plus? Plus
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.NumberDataSourceType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.NumberDataSourceType");
  }
  
  
  /// <summary>
  ///   Minus.
  /// </summary>
  [DataMember]
  public DMDC.Minus? Minus
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.NumberDataSourceType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.NumberDataSourceType");
  }
  
  
  /// <summary>
  ///   Error Bar Value.
  /// </summary>
  [DataMember]
  public DMDC.ErrorBarValue? ErrorBarValue
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.DoubleType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.DoubleType");
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
  ///   Chart Extensibility.
  /// </summary>
  [DataMember]
  public DMDC.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
