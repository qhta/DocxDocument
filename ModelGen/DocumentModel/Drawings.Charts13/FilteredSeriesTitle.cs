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
      var element = _Element?.GetFirstChild<DXO13DC.ChartText>();
      if (element != null)
        return ChartTextConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.ChartText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartTextConverter.CreateOpenXmlElement<DXO13DC.ChartText>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
