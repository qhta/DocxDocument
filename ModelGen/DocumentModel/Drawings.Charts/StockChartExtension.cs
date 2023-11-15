namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the StockChartExtension Class.
/// </summary>
public partial class StockChartExtension: ModelElement<DXDC.StockChartExtension>
{
  public StockChartExtension(): base(){ }
  
  public StockChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StockChartExtension(DXDC.StockChartExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC13.FilteredLineSeriesExtension? FilteredLineSeriesExtension
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
