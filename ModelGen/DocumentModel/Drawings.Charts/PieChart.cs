namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Pie Charts.
/// </summary>
public partial class PieChart: ModelElement<DXDC.PieChart>
{
  public PieChart(): base(){ }
  
  public PieChart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PieChart(DXDC.PieChart openXmlElement): base(openXmlElement) { }
  
  
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
  public UInt16? FirstSliceAngle
  {
    get => _Element?.GetIntVal<UInt16, DXDC.FirstSliceAngle>();
    set => _ExistingElement.SetIntVal<UInt16, DXDC.FirstSliceAngle>(value);
  }
  
  [DataMember]
  public DMDC.PieChartExtensionList? PieChartExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
