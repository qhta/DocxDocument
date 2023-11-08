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
      var element = _Element?.GetFirstChild<DXO13DC.FilteredPieSeries>();
      if (element != null)
        return FilteredPieSeriesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.FilteredPieSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FilteredPieSeriesConverter.CreateOpenXmlElement<DXO13DC.FilteredPieSeries>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
