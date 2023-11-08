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
    get
    {
      return StringValueConverter.GetValue(_Element?.Uri);
    }
    set
    {
      _ExistingElement.Uri = StringValueConverter.CreateStringValue(value);
    }
  }
  
  [DataMember]
  public DMDC13.FilteredLineSeriesExtension? FilteredLineSeriesExtension
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.FilteredLineSeriesExtension>();
      if (element != null)
        return FilteredLineSeriesExtensionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.FilteredLineSeriesExtension>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FilteredLineSeriesExtensionConverter.CreateOpenXmlElement<DXO13DC.FilteredLineSeriesExtension>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
