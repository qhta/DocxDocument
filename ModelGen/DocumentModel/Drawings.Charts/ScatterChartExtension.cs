namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ScatterChartExtension Class.
/// </summary>
public partial class ScatterChartExtension: ModelElement<DXDC.ScatterChartExtension>
{
  public ScatterChartExtension(): base(){ }
  
  public ScatterChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ScatterChartExtension(DXDC.ScatterChartExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC13.FilteredScatterSeries? FilteredScatterSeries
  {
    get
    {
      return _Element?.GetObject<DMDC13.FilteredScatterSeries,DXO13DC.FilteredScatterSeries>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.FilteredScatterSeries,DXO13DC.FilteredScatterSeries>(value);
    }
  }
  
}
