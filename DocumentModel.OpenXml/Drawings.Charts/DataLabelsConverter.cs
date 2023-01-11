namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Data Labels.
/// </summary>
public static class DataLabelsConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DataLabel>? GetItems(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DataLabel>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.DataLabel>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.DataLabelConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DataLabel>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.DataLabel>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.DataLabelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DataLabel>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static Boolean? GetDelete(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Delete>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDelete(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement, Boolean? value)
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
  
  public static DocumentModel.Drawings.Charts.NumberingFormat? GetNumberingFormat(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.NumberingFormatConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNumberingFormat(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement, DocumentModel.Drawings.Charts.NumberingFormat? value)
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
  
  public static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
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
  
  public static DocumentModel.Drawings.Charts.TextProperties? GetTextProperties(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.TextPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTextProperties(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement, DocumentModel.Drawings.Charts.TextProperties? value)
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
  
  public static DocumentModel.Drawings.Charts.DataLabelPositionKind? GetDataLabelPosition(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement)
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
  
  public static void SetDataLabelPosition(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement, DocumentModel.Drawings.Charts.DataLabelPositionKind? value)
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
  
  public static Boolean? GetShowLegendKey(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowLegendKey>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetShowLegendKey(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement, Boolean? value)
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
  
  public static Boolean? GetShowValue(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowValue>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetShowValue(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement, Boolean? value)
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
  
  public static Boolean? GetShowCategoryName(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowCategoryName>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetShowCategoryName(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement, Boolean? value)
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
  
  public static Boolean? GetShowSeriesName(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowSeriesName>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetShowSeriesName(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement, Boolean? value)
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
  
  public static Boolean? GetShowPercent(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowPercent>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetShowPercent(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement, Boolean? value)
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
  
  public static Boolean? GetShowBubbleSize(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowBubbleSize>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetShowBubbleSize(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement, Boolean? value)
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
  
  public static String? GetSeparator(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Separator");
  }
  
  public static void SetSeparator(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Separator");
  }
  
  public static Boolean? GetShowLeaderLines(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowLeaderLines>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetShowLeaderLines(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowLeaderLines>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.ShowLeaderLines();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.LeaderLines? GetLeaderLines(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LeaderLines>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.LeaderLinesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLeaderLines(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement, DocumentModel.Drawings.Charts.LeaderLines? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LeaderLines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.LeaderLinesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LeaderLines>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DLblsExtensionList? GetDLblsExtensionList(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DLblsExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DLblsExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDLblsExtensionList(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement, DocumentModel.Drawings.Charts.DLblsExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DLblsExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.DLblsExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DLblsExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DataLabels? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DataLabels();
      value.Items = GetItems(openXmlElement);
      value.Delete = GetDelete(openXmlElement);
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
      value.ShowLeaderLines = GetShowLeaderLines(openXmlElement);
      value.LeaderLines = GetLeaderLines(openXmlElement);
      value.DLblsExtensionList = GetDLblsExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.DataLabels? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.DataLabels, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
