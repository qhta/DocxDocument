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
      var element = _Element?.GetFirstChild<DXDC.Index>();
      if (element != null)
        return IndexConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Index>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = IndexConverter.CreateOpenXmlElement<DXDC.Index>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.Delete? Delete
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.Delete>();
      if (element != null)
        return DeleteConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Delete>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DeleteConverter.CreateOpenXmlElement<DXDC.Delete>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.Layout? Layout
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.Layout>();
      if (element != null)
        return LayoutConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Layout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LayoutConverter.CreateOpenXmlElement<DXDC.Layout>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.ChartText? ChartText
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ChartText>();
      if (element != null)
        return ChartTextConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ChartText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartTextConverter.CreateOpenXmlElement<DXDC.ChartText>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.NumberingFormat? NumberingFormat
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.NumberingFormat>();
      if (element != null)
        return NumberingFormatConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.NumberingFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberingFormatConverter.CreateOpenXmlElement<DXDC.NumberingFormat>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.ChartShapeProperties? ChartShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ChartShapeProperties>();
      if (element != null)
        return ChartShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ChartShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartShapePropertiesConverter.CreateOpenXmlElement<DXDC.ChartShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.TextProperties? TextProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.TextProperties>();
      if (element != null)
        return TextPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.TextProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextPropertiesConverter.CreateOpenXmlElement<DXDC.TextProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.ShowLegendKey>();
      if (element != null)
        return ShowLegendKeyConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ShowLegendKey>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShowLegendKeyConverter.CreateOpenXmlElement<DXDC.ShowLegendKey>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.ShowValue? ShowValue
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ShowValue>();
      if (element != null)
        return ShowValueConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ShowValue>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShowValueConverter.CreateOpenXmlElement<DXDC.ShowValue>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.ShowCategoryName? ShowCategoryName
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ShowCategoryName>();
      if (element != null)
        return ShowCategoryNameConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ShowCategoryName>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShowCategoryNameConverter.CreateOpenXmlElement<DXDC.ShowCategoryName>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.ShowSeriesName? ShowSeriesName
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ShowSeriesName>();
      if (element != null)
        return ShowSeriesNameConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ShowSeriesName>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShowSeriesNameConverter.CreateOpenXmlElement<DXDC.ShowSeriesName>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.ShowPercent? ShowPercent
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ShowPercent>();
      if (element != null)
        return ShowPercentConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ShowPercent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShowPercentConverter.CreateOpenXmlElement<DXDC.ShowPercent>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.ShowBubbleSize? ShowBubbleSize
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ShowBubbleSize>();
      if (element != null)
        return ShowBubbleSizeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ShowBubbleSize>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShowBubbleSizeConverter.CreateOpenXmlElement<DXDC.ShowBubbleSize>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.Separator? Separator
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.Separator>();
      if (element != null)
        return SeparatorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Separator>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SeparatorConverter.CreateOpenXmlElement<DXDC.Separator>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.DLblExtensionList? DLblExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.DLblExtensionList>();
      if (element != null)
        return DLblExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.DLblExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DLblExtensionListConverter.CreateOpenXmlElement<DXDC.DLblExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
