namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the Line3DChartExtension Class.
/// </summary>
public partial class Line3DChartExtension: ModelElement<DXDC.Line3DChartExtension>
{
  public Line3DChartExtension(): base(){ }
  
  public Line3DChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Line3DChartExtension(DXDC.Line3DChartExtension openXmlElement): base(openXmlElement) { }
  
  
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
