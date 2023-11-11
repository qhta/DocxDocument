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
  public DMDC13.FilteredBarSeries? FilteredBarSeries
  {
    get
    {
      return _Element?.GetObject<DMDC13.FilteredBarSeries,DXO13DC.FilteredBarSeries>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.FilteredBarSeries,DXO13DC.FilteredBarSeries>(value);
    }
  }
  
}
