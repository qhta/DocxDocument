namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Doughnut Charts.
/// </summary>
public partial class DoughnutChart: ModelElement<DXDC.DoughnutChart>
{
  public DoughnutChart(): base(){ }
  
  public DoughnutChart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DoughnutChart(DXDC.DoughnutChart openXmlElement): base(openXmlElement) { }
  
  
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
  public Byte? HoleSize
  {
    get => _Element?.GetIntVal<Byte, DXDC.HoleSize>();
    set => _ExistingElement.SetIntVal<Byte, DXDC.HoleSize>(value);
  }
  
  [DataMember]
  public DMDC.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
