namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Data Label.
/// </summary>
public partial class DataLabel: ModelElement<DXDC.DataLabel>
{
  public DataLabel(): base(){ }
  
  public DataLabel(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataLabel(DXDC.DataLabel openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Index.
  /// </summary>
  [DataMember]
  public DMDC.Index? Index
  {
    get
    {
      return _Element?.GetObject<DMDC.Index,DXDC.Index>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Index,DXDC.Index>(value);
    }
  }
  
  [DataMember]
  public DMDC.Delete? Delete
  {
    get
    {
      return _Element?.GetObject<DMDC.Delete,DXDC.Delete>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Delete,DXDC.Delete>(value);
    }
  }
  
  [DataMember]
  public DMDC.Layout? Layout
  {
    get
    {
      return _Element?.GetObject<DMDC.Layout,DXDC.Layout>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Layout,DXDC.Layout>(value);
    }
  }
  
  [DataMember]
  public DMDC.ChartText? ChartText
  {
    get
    {
      return _Element?.GetObject<DMDC.ChartText,DXDC.ChartText>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ChartText,DXDC.ChartText>(value);
    }
  }
  
  [DataMember]
  public DMDC.NumberingFormat? NumberingFormat
  {
    get
    {
      return _Element?.GetObject<DMDC.NumberingFormat,DXDC.NumberingFormat>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.NumberingFormat,DXDC.NumberingFormat>(value);
    }
  }
  
  [DataMember]
  public DMDC.ChartShapeProperties? ChartShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMDC.ChartShapeProperties,DXDC.ChartShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ChartShapeProperties,DXDC.ChartShapeProperties>(value);
    }
  }
  
  [DataMember]
  public DMDC.TextProperties? TextProperties
  {
    get
    {
      return _Element?.GetObject<DMDC.TextProperties,DXDC.TextProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.TextProperties,DXDC.TextProperties>(value);
    }
  }
  
  [DataMember]
  public DMDC.DataLabelPositionKind? DataLabelPosition
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues, DMDC.DataLabelPositionKind>(_ExistingElement.GetFirstChild<DXDC.DataLabelPosition>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.DataLabelPosition>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues, DMDC.DataLabelPositionKind>(itemElement, (DMDC.DataLabelPositionKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.DataLabelPosition, DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues, DMDC.DataLabelPositionKind>((DMDC.DataLabelPositionKind)value));
    }
  }
  
  [DataMember]
  public DMDC.ShowLegendKey? ShowLegendKey
  {
    get
    {
      return _Element?.GetObject<DMDC.ShowLegendKey,DXDC.ShowLegendKey>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ShowLegendKey,DXDC.ShowLegendKey>(value);
    }
  }
  
  [DataMember]
  public DMDC.ShowValue? ShowValue
  {
    get
    {
      return _Element?.GetObject<DMDC.ShowValue,DXDC.ShowValue>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ShowValue,DXDC.ShowValue>(value);
    }
  }
  
  [DataMember]
  public DMDC.ShowCategoryName? ShowCategoryName
  {
    get
    {
      return _Element?.GetObject<DMDC.ShowCategoryName,DXDC.ShowCategoryName>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ShowCategoryName,DXDC.ShowCategoryName>(value);
    }
  }
  
  [DataMember]
  public DMDC.ShowSeriesName? ShowSeriesName
  {
    get
    {
      return _Element?.GetObject<DMDC.ShowSeriesName,DXDC.ShowSeriesName>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ShowSeriesName,DXDC.ShowSeriesName>(value);
    }
  }
  
  [DataMember]
  public DMDC.ShowPercent? ShowPercent
  {
    get
    {
      return _Element?.GetObject<DMDC.ShowPercent,DXDC.ShowPercent>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ShowPercent,DXDC.ShowPercent>(value);
    }
  }
  
  [DataMember]
  public DMDC.ShowBubbleSize? ShowBubbleSize
  {
    get
    {
      return _Element?.GetObject<DMDC.ShowBubbleSize,DXDC.ShowBubbleSize>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ShowBubbleSize,DXDC.ShowBubbleSize>(value);
    }
  }
  
  [DataMember]
  public DMDC.Separator? Separator
  {
    get
    {
      return _Element?.GetObject<DMDC.Separator,DXDC.Separator>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Separator,DXDC.Separator>(value);
    }
  }
  
  [DataMember]
  public DMDC.DLblExtensionList? DLblExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.DLblExtensionList,DXDC.DLblExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.DLblExtensionList,DXDC.DLblExtensionList>(value);
    }
  }
  
}
