namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Data Labels.
/// </summary>
public static class DataLabelsConverter
{
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DataLabel> GetItems(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement)
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
  
  private static void SetItems(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DataLabel>? value)
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
  
  private static Boolean? GetDelete(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Delete>();
    return itemElement != null;
  }
  
  private static void SetDelete(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement, Boolean? value)
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
  
  private static DocumentModel.Drawings.Charts.NumberingFormat? GetNumberingFormat(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.NumberingFormatConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNumberingFormat(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement, DocumentModel.Drawings.Charts.NumberingFormat? value)
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
  
  private static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
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
  
  private static DocumentModel.Drawings.Charts.TextProperties? GetTextProperties(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.TextPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextProperties(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement, DocumentModel.Drawings.Charts.TextProperties? value)
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
  
  private static DocumentModel.Drawings.Charts.DataLabelPositionKind? GetDataLabelPosition(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues, DocumentModel.Drawings.Charts.DataLabelPositionKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetDataLabelPosition(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement, DocumentModel.Drawings.Charts.DataLabelPositionKind? value)
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
  
  private static Boolean? GetShowLegendKey(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowLegendKey>();
    return itemElement != null;
  }
  
  private static void SetShowLegendKey(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement, Boolean? value)
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
  
  private static Boolean? GetShowValue(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowValue>();
    return itemElement != null;
  }
  
  private static void SetShowValue(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement, Boolean? value)
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
  
  private static Boolean? GetShowCategoryName(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowCategoryName>();
    return itemElement != null;
  }
  
  private static void SetShowCategoryName(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement, Boolean? value)
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
  
  private static Boolean? GetShowSeriesName(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowSeriesName>();
    return itemElement != null;
  }
  
  private static void SetShowSeriesName(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement, Boolean? value)
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
  
  private static Boolean? GetShowPercent(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowPercent>();
    return itemElement != null;
  }
  
  private static void SetShowPercent(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement, Boolean? value)
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
  
  private static Boolean? GetShowBubbleSize(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowBubbleSize>();
    return itemElement != null;
  }
  
  private static void SetShowBubbleSize(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement, Boolean? value)
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
  
  private static String? GetSeparator(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Separator>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetSeparator(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Separator>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Separator { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetShowLeaderLines(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowLeaderLines>();
    return itemElement != null;
  }
  
  private static void SetShowLeaderLines(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement, Boolean? value)
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
  
  private static DocumentModel.Drawings.Charts.LeaderLines? GetLeaderLines(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LeaderLines>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.LeaderLinesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLeaderLines(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement, DocumentModel.Drawings.Charts.LeaderLines? value)
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
  
  private static DocumentModel.Drawings.Charts.DLblsExtensionList? GetDLblsExtensionList(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DLblsExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DLblsExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDLblsExtensionList(DocumentFormat.OpenXml.Drawing.Charts.DataLabels openXmlElement, DocumentModel.Drawings.Charts.DLblsExtensionList? value)
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      SetDelete(openXmlElement, value?.Delete);
      SetNumberingFormat(openXmlElement, value?.NumberingFormat);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetTextProperties(openXmlElement, value?.TextProperties);
      SetDataLabelPosition(openXmlElement, value?.DataLabelPosition);
      SetShowLegendKey(openXmlElement, value?.ShowLegendKey);
      SetShowValue(openXmlElement, value?.ShowValue);
      SetShowCategoryName(openXmlElement, value?.ShowCategoryName);
      SetShowSeriesName(openXmlElement, value?.ShowSeriesName);
      SetShowPercent(openXmlElement, value?.ShowPercent);
      SetShowBubbleSize(openXmlElement, value?.ShowBubbleSize);
      SetSeparator(openXmlElement, value?.Separator);
      SetShowLeaderLines(openXmlElement, value?.ShowLeaderLines);
      SetLeaderLines(openXmlElement, value?.LeaderLines);
      SetDLblsExtensionList(openXmlElement, value?.DLblsExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
