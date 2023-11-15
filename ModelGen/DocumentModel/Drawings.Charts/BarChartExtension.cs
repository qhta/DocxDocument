namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the BarChartExtension Class.
/// </summary>
public partial class BarChartExtension: ModelElement<DXDC.BarChartExtension>
{
  public BarChartExtension(): base(){ }
  
  public BarChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BarChartExtension(DXDC.BarChartExtension openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   URI
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get => _Element?.Uri;
    set => _ExistingElement.Uri = value;
  }
  
  [DataMember]
  public DMDC13.FilteredBarSeries? FilteredBarSeries
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
