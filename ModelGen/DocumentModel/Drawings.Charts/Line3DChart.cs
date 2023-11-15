namespace DocumentModel.Drawings.Charts;


/// <summary>
///   3D Line Charts.
/// </summary>
public partial class Line3DChart: ModelElement<DXDC.Line3DChart>
{
  public Line3DChart(): base(){ }
  
  public Line3DChart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Line3DChart(DXDC.Line3DChart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Grouping.
  /// </summary>
  [DataMember]
  public DMDC.GroupingKind? Grouping
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  [DataMember]
  public DMDC.VaryColors? VaryColors
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
  }
  
  [DataMember]
  public DMDC.DataLabels? DataLabels
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMDC.DropLines? DropLines
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.ChartLinesType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.ChartLinesType");
  }
  
  [DataMember]
  public DMDC.GapDepth? GapDepth
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.GapAmountType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.GapAmountType");
  }
  
  [DataMember]
  public DMDC.Line3DChartExtensionList? Line3DChartExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
