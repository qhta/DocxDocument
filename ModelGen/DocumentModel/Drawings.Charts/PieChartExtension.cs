namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the PieChartExtension Class.
/// </summary>
public partial class PieChartExtension: ModelElement<DXDC.PieChartExtension>
{
  public PieChartExtension(): base(){ }
  
  public PieChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PieChartExtension(DXDC.PieChartExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC13.FilteredPieSeries? FilteredPieSeries
  {
    get
    {
      return _Element?.GetObject<DMDC13.FilteredPieSeries,DXO13DC.FilteredPieSeries>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.FilteredPieSeries,DXO13DC.FilteredPieSeries>(value);
    }
  }
  
}
