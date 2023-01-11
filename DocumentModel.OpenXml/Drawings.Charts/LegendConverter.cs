namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Legend data and formatting.
/// </summary>
public static class LegendConverter
{
  /// <summary>
  /// Legend Position.
  /// </summary>
  public static DocumentModel.Drawings.Charts.LegendPositionKind? GetLegendPosition(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LegendPosition>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LegendPositionValues, DocumentModel.Drawings.Charts.LegendPositionKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetLegendPosition(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement, DocumentModel.Drawings.Charts.LegendPositionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LegendPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LegendPosition, DocumentFormat.OpenXml.Drawing.Charts.LegendPositionValues, DocumentModel.Drawings.Charts.LegendPositionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.LegendEntry>? GetLegendEntries(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.LegendEntry>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.LegendEntry>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.LegendEntryConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetLegendEntries(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.LegendEntry>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.LegendEntry>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.LegendEntryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LegendEntry>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.Layout? GetLayout(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Layout>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.LayoutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLayout(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement, DocumentModel.Drawings.Charts.Layout? value)
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
  
  public static Boolean? GetOverlay(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Overlay>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetOverlay(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Overlay>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Overlay();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
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
  
  public static DocumentModel.Drawings.Charts.TextProperties? GetTextProperties(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.TextPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTextProperties(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement, DocumentModel.Drawings.Charts.TextProperties? value)
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
  
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.Legend? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Legend();
      value.LegendPosition = GetLegendPosition(openXmlElement);
      value.LegendEntries = GetLegendEntries(openXmlElement);
      value.Layout = GetLayout(openXmlElement);
      value.Overlay = GetOverlay(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.TextProperties = GetTextProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Legend? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.Legend, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
