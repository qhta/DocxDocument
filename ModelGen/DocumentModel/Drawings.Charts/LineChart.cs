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
      var element = _Element?.GetFirstChild<DXDC.VaryColors>();
      if (element != null)
        return VaryColorsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.VaryColors>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = VaryColorsConverter.CreateOpenXmlElement<DXDC.VaryColors>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.DataLabels? DataLabels
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.DataLabels>();
      if (element != null)
        return DataLabelsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.DataLabels>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabelsConverter.CreateOpenXmlElement<DXDC.DataLabels>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.DropLines? DropLines
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.DropLines>();
      if (element != null)
        return DropLinesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.DropLines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DropLinesConverter.CreateOpenXmlElement<DXDC.DropLines>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.HighLowLines? HighLowLines
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.HighLowLines>();
      if (element != null)
        return HighLowLinesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.HighLowLines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HighLowLinesConverter.CreateOpenXmlElement<DXDC.HighLowLines>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.UpDownBars? UpDownBars
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.UpDownBars>();
      if (element != null)
        return UpDownBarsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.UpDownBars>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UpDownBarsConverter.CreateOpenXmlElement<DXDC.UpDownBars>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.ShowMarker? ShowMarker
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ShowMarker>();
      if (element != null)
        return ShowMarkerConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ShowMarker>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShowMarkerConverter.CreateOpenXmlElement<DXDC.ShowMarker>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.Smooth? Smooth
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.Smooth>();
      if (element != null)
        return SmoothConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Smooth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SmoothConverter.CreateOpenXmlElement<DXDC.Smooth>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.LineChartExtensionList? LineChartExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.LineChartExtensionList>();
      if (element != null)
        return LineChartExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.LineChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineChartExtensionListConverter.CreateOpenXmlElement<DXDC.LineChartExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
