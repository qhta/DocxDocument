namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Data Labels.
/// </summary>
public partial class DataLabels: ModelElement<DXDC.DataLabels>
{
  public DataLabels(): base(){ }
  
  public DataLabels(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataLabels(DXDC.DataLabels openXmlElement): base(openXmlElement) { }
  
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
  public DMDC.ShowLeaderLines? ShowLeaderLines
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ShowLeaderLines>();
      if (element != null)
        return ShowLeaderLinesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ShowLeaderLines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShowLeaderLinesConverter.CreateOpenXmlElement<DXDC.ShowLeaderLines>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.LeaderLines? LeaderLines
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.LeaderLines>();
      if (element != null)
        return LeaderLinesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.LeaderLines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LeaderLinesConverter.CreateOpenXmlElement<DXDC.LeaderLines>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.DLblsExtensionList? DLblsExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.DLblsExtensionList>();
      if (element != null)
        return DLblsExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.DLblsExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DLblsExtensionListConverter.CreateOpenXmlElement<DXDC.DLblsExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
