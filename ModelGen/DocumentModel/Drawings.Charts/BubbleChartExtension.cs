namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the BubbleChartExtension Class.
/// </summary>
public partial class BubbleChartExtension: ModelElement<DXDC.BubbleChartExtension>
{
  public BubbleChartExtension(): base(){ }
  
  public BubbleChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BubbleChartExtension(DXDC.BubbleChartExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC13.FilteredBubbleSeries? FilteredBubbleSeries
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.FilteredBubbleSeries>();
      if (element != null)
        return FilteredBubbleSeriesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.FilteredBubbleSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FilteredBubbleSeriesConverter.CreateOpenXmlElement<DXO13DC.FilteredBubbleSeries>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
