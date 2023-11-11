namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the LineChartExtension Class.
/// </summary>
public partial class LineChartExtension: ModelElement<DXDC.LineChartExtension>
{
  public LineChartExtension(): base(){ }
  
  public LineChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineChartExtension(DXDC.LineChartExtension openXmlElement): base(openXmlElement) { }
  
  
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
      return _Element?.GetObject<DMDC13.FilteredLineSeriesExtension,DXO13DC.FilteredLineSeriesExtension>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.FilteredLineSeriesExtension,DXO13DC.FilteredLineSeriesExtension>(value);
    }
  }
  
}
