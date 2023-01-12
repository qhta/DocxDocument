namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DataLabel Class.
/// </summary>
public static class DataLabel3Converter
{
  /// <summary>
  /// Index.
  /// </summary>
  public static UInt32? GetIndex(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Index>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetIndex(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Index>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Index{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetDelete(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Delete>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDelete(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Delete>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Delete();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.Layout? GetLayout(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Layout>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.LayoutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLayout(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, DocumentModel.Drawings.Charts.Layout? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Layout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.LayoutConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Layout>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.ChartText? GetChartText(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartText>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartTextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChartText(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, DocumentModel.Drawings.Charts.ChartText? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.ChartTextConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ChartText>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.NumberingFormat? GetNumberingFormat(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.NumberingFormatConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNumberingFormat(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, DocumentModel.Drawings.Charts.NumberingFormat? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.NumberingFormatConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChartShapeProperties(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.TextProperties? GetTextProperties(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.TextPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTextProperties(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, DocumentModel.Drawings.Charts.TextProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.TextPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DataLabelPositionKind? GetDataLabelPosition(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues, DocumentModel.Drawings.Charts.DataLabelPositionKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetDataLabelPosition(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, DocumentModel.Drawings.Charts.DataLabelPositionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition, DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues, DocumentModel.Drawings.Charts.DataLabelPositionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetShowLegendKey(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowLegendKey>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetShowLegendKey(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowLegendKey>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.ShowLegendKey();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetShowValue(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowValue>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetShowValue(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowValue>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.ShowValue();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetShowCategoryName(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowCategoryName>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetShowCategoryName(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowCategoryName>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.ShowCategoryName();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetShowSeriesName(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowSeriesName>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetShowSeriesName(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowSeriesName>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.ShowSeriesName();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetShowPercent(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowPercent>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetShowPercent(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowPercent>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.ShowPercent();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetShowBubbleSize(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowBubbleSize>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetShowBubbleSize(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowBubbleSize>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.ShowBubbleSize();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static String? GetSeparator(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Separator");
  }
  
  public static void SetSeparator(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Separator");
  }
  
  public static DocumentModel.Drawings.Charts.DLblExtensionList? GetDLblExtensionList(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DLblExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDLblExtensionList(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, DocumentModel.Drawings.Charts.DLblExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.DLblExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DataLabel3? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DataLabel3();
      value.Index = GetIndex(openXmlElement);
      value.Delete = GetDelete(openXmlElement);
      value.Layout = GetLayout(openXmlElement);
      value.ChartText = GetChartText(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.TextProperties = GetTextProperties(openXmlElement);
      value.DataLabelPosition = GetDataLabelPosition(openXmlElement);
      value.ShowLegendKey = GetShowLegendKey(openXmlElement);
      value.ShowValue = GetShowValue(openXmlElement);
      value.ShowCategoryName = GetShowCategoryName(openXmlElement);
      value.ShowSeriesName = GetShowSeriesName(openXmlElement);
      value.ShowPercent = GetShowPercent(openXmlElement);
      value.ShowBubbleSize = GetShowBubbleSize(openXmlElement);
      value.Separator = GetSeparator(openXmlElement);
      value.DLblExtensionList = GetDLblExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.DataLabel3? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      return openXmlElement;
    }
    return default;
  }
}
