namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Bar Charts.
/// </summary>
public static class BarChartConverter
{
  /// <summary>
  /// Bar Direction.
  /// </summary>
  public static DocumentModel.Drawings.Charts.BarDirectionKind? GetBarDirection(DocumentFormat.OpenXml.Drawing.Charts.BarChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BarDirection>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues, DocumentModel.Drawings.Charts.BarDirectionKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetBarDirection(DocumentFormat.OpenXml.Drawing.Charts.BarChart? openXmlElement, DocumentModel.Drawings.Charts.BarDirectionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BarDirection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BarDirection, DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues, DocumentModel.Drawings.Charts.BarDirectionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Bar Grouping.
  /// </summary>
  public static DocumentModel.Drawings.Charts.BarGroupingKind? GetBarGrouping(DocumentFormat.OpenXml.Drawing.Charts.BarChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BarGrouping>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues, DocumentModel.Drawings.Charts.BarGroupingKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetBarGrouping(DocumentFormat.OpenXml.Drawing.Charts.BarChart? openXmlElement, DocumentModel.Drawings.Charts.BarGroupingKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BarGrouping>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BarGrouping, DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues, DocumentModel.Drawings.Charts.BarGroupingKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public static Boolean? GetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.BarChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.VaryColors>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.BarChart? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.BarChartSeries>? GetBarChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.BarChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.BarChartSeries>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.BarChartSeriesConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetBarChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.BarChart? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.BarChartSeries>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.BarChartSeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DataLabels? GetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.BarChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.BarChart? openXmlElement, DocumentModel.Drawings.Charts.DataLabels? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static UInt16? GetGapWidth(DocumentFormat.OpenXml.Drawing.Charts.BarChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.GapWidth");
  }
  
  public static void SetGapWidth(DocumentFormat.OpenXml.Drawing.Charts.BarChart? openXmlElement, UInt16? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.GapWidth");
  }
  
  public static SByte? GetOverlap(DocumentFormat.OpenXml.Drawing.Charts.BarChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Overlap");
  }
  
  public static void SetOverlap(DocumentFormat.OpenXml.Drawing.Charts.BarChart? openXmlElement, SByte? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Overlap");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.SeriesLines>? GetSeriesLineses(DocumentFormat.OpenXml.Drawing.Charts.BarChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.SeriesLines>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.SeriesLines>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.SeriesLinesConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetSeriesLineses(DocumentFormat.OpenXml.Drawing.Charts.BarChart? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.SeriesLines>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.SeriesLines>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.SeriesLinesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesLines>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<UInt32>? GetAxisIds(DocumentFormat.OpenXml.Drawing.Charts.BarChart? openXmlElement)
  {
    if (openXmlElement != null)
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
    return null;
  }
  
  public static void SetAxisIds(DocumentFormat.OpenXml.Drawing.Charts.BarChart? openXmlElement, System.Collections.ObjectModel.Collection<UInt32>? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Charts.BarChartExtensionList? GetBarChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.BarChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BarChartExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.BarChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBarChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.BarChart? openXmlElement, DocumentModel.Drawings.Charts.BarChartExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BarChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.BarChartExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BarChartExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.BarChart? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.BarChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BarChart();
      value.BarDirection = GetBarDirection(openXmlElement);
      value.BarGrouping = GetBarGrouping(openXmlElement);
      value.VaryColors = GetVaryColors(openXmlElement);
      value.BarChartSerieses = GetBarChartSerieses(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.GapWidth = GetGapWidth(openXmlElement);
      value.Overlap = GetOverlap(openXmlElement);
      value.SeriesLineses = GetSeriesLineses(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.BarChartExtensionList = GetBarChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.BarChart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.BarChart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
