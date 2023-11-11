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
      return _Element?.GetObject<DMDC13.FilteredBubbleSeries,DXO13DC.FilteredBubbleSeries>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.FilteredBubbleSeries,DXO13DC.FilteredBubbleSeries>(value);
    }
  }
  
}
