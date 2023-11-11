namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the FilteredSeriesTitle Class.
/// </summary>
public partial class FilteredSeriesTitle: ModelElement<DXO13DC.FilteredSeriesTitle>
{
  public FilteredSeriesTitle(): base(){ }
  
  public FilteredSeriesTitle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FilteredSeriesTitle(DXO13DC.FilteredSeriesTitle openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ChartText.
  /// </summary>
  [DataMember]
  public DMDC13.ChartText? ChartText
  {
    get
    {
      return _Element?.GetObject<DMDC13.ChartText,DXO13DC.ChartText>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.ChartText,DXO13DC.ChartText>(value);
    }
  }
  
}
