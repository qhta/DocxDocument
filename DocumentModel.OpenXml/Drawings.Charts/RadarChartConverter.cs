namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Radar Charts.
/// </summary>
public static class RadarChartConverter
{
  /// <summary>
  /// RadarStyle.
  /// </summary>
  private static DocumentModel.Drawings.Charts.RadarStyleKind? GetRadarStyle(DocumentFormat.OpenXml.Drawing.Charts.RadarChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RadarStyle>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.RadarStyleValues, DocumentModel.Drawings.Charts.RadarStyleKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetRadarStyle(DocumentFormat.OpenXml.Drawing.Charts.RadarChart openXmlElement, DocumentModel.Drawings.Charts.RadarStyleKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RadarStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.RadarStyle, DocumentFormat.OpenXml.Drawing.Charts.RadarStyleValues, DocumentModel.Drawings.Charts.RadarStyleKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  private static Boolean? GetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.RadarChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.VaryColors>();
    return itemElement != null;
  }
  
  private static void SetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.RadarChart openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.VaryColors>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.VaryColors();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.RadarChartSeries> GetRadarChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.RadarChart openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.RadarChartSeries>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.RadarChartSeries>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.Charts.RadarChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetRadarChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.RadarChart openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.RadarChartSeries>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.RadarChartSeries>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.RadarChartSeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.RadarChartSeries>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DocumentModel.Drawings.Charts.DataLabels? GetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.RadarChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.RadarChart openXmlElement, DocumentModel.Drawings.Charts.DataLabels? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.DataLabelsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static System.Collections.ObjectModel.Collection<UInt32> GetAxisIds(DocumentFormat.OpenXml.Drawing.Charts.RadarChart openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<UInt32>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.AxisId>())
    {
      var newItem = UInt32ValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((UInt32)newItem);
    }
    return collection;
  }
  
  private static void SetAxisIds(DocumentFormat.OpenXml.Drawing.Charts.RadarChart openXmlElement, System.Collections.ObjectModel.Collection<UInt32>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.AxisId>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = UInt32ValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.AxisId>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DocumentModel.Drawings.Charts.RadarChartExtensionList? GetRadarChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.RadarChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.RadarChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRadarChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.RadarChart openXmlElement, DocumentModel.Drawings.Charts.RadarChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.RadarChartExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.RadarChart? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.RadarChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.RadarChart();
      value.RadarStyle = GetRadarStyle(openXmlElement);
      value.VaryColors = GetVaryColors(openXmlElement);
      value.RadarChartSerieses = GetRadarChartSerieses(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.RadarChartExtensionList = GetRadarChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.RadarChart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.RadarChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRadarStyle(openXmlElement, value?.RadarStyle);
      SetVaryColors(openXmlElement, value?.VaryColors);
      SetRadarChartSerieses(openXmlElement, value?.RadarChartSerieses);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetAxisIds(openXmlElement, value?.AxisIds);
      SetRadarChartExtensionList(openXmlElement, value?.RadarChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
