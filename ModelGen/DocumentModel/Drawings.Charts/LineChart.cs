namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Line Charts.
/// </summary>
public partial class LineChart: ModelElement<DXDC.LineChart>
{
  public LineChart(): base(){ }
  
  public LineChart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineChart(DXDC.LineChart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Grouping.
  /// </summary>
  [DataMember]
  public DMDC.GroupingKind? Grouping
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDC.GroupingKind>(_ExistingElement.GetFirstChild<DXDC.Grouping>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Grouping>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDC.GroupingKind>(itemElement, (DMDC.GroupingKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.Grouping, DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDC.GroupingKind>((DMDC.GroupingKind)value));
    }
  }
  
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  [DataMember]
  public DMDC.VaryColors? VaryColors
  {
    get
    {
      return _Element?.GetObject<DMDC.VaryColors,DXDC.VaryColors>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.VaryColors,DXDC.VaryColors>(value);
    }
  }
  
  [DataMember]
  public DMDC.DataLabels? DataLabels
  {
    get
    {
      return _Element?.GetObject<DMDC.DataLabels,DXDC.DataLabels>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.DataLabels,DXDC.DataLabels>(value);
    }
  }
  
  [DataMember]
  public DMDC.DropLines? DropLines
  {
    get
    {
      return _Element?.GetObject<DMDC.DropLines,DXDC.DropLines>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.DropLines,DXDC.DropLines>(value);
    }
  }
  
  [DataMember]
  public DMDC.HighLowLines? HighLowLines
  {
    get
    {
      return _Element?.GetObject<DMDC.HighLowLines,DXDC.HighLowLines>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.HighLowLines,DXDC.HighLowLines>(value);
    }
  }
  
  [DataMember]
  public DMDC.UpDownBars? UpDownBars
  {
    get
    {
      return _Element?.GetObject<DMDC.UpDownBars,DXDC.UpDownBars>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.UpDownBars,DXDC.UpDownBars>(value);
    }
  }
  
  [DataMember]
  public DMDC.ShowMarker? ShowMarker
  {
    get
    {
      return _Element?.GetObject<DMDC.ShowMarker,DXDC.ShowMarker>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ShowMarker,DXDC.ShowMarker>(value);
    }
  }
  
  [DataMember]
  public DMDC.Smooth? Smooth
  {
    get
    {
      return _Element?.GetObject<DMDC.Smooth,DXDC.Smooth>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Smooth,DXDC.Smooth>(value);
    }
  }
  
  [DataMember]
  public DMDC.LineChartExtensionList? LineChartExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.LineChartExtensionList,DXDC.LineChartExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.LineChartExtensionList,DXDC.LineChartExtensionList>(value);
    }
  }
  
}
