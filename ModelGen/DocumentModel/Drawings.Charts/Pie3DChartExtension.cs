namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the Pie3DChartExtension Class.
/// </summary>
public partial class Pie3DChartExtension: ModelElement<DXDC.Pie3DChartExtension>
{
  public Pie3DChartExtension(): base(){ }
  
  public Pie3DChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Pie3DChartExtension(DXDC.Pie3DChartExtension openXmlElement): base(openXmlElement) { }
  
  
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
