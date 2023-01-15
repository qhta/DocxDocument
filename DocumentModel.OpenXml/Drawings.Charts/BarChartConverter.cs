using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.Charts;
using BarChart = DocumentFormat.OpenXml.Drawing.Charts.BarChart;
using BarChartExtensionList = DocumentModel.Drawings.Charts.BarChartExtensionList;
using BarChartSeries = DocumentModel.Drawings.Charts.BarChartSeries;
using DataLabels = DocumentModel.Drawings.Charts.DataLabels;
using SeriesLines = DocumentModel.Drawings.Charts.SeriesLines;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Bar Charts.
/// </summary>
public static class BarChartConverter
{
  /// <summary>
  ///   Bar Direction.
  /// </summary>
  public static BarDirectionKind? GetBarDirection(BarChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BarDirection>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BarDirectionValues, BarDirectionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetBarDirection(BarChart? openXmlElement, BarDirectionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BarDirection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<BarDirection, BarDirectionValues, BarDirectionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Bar Grouping.
  /// </summary>
  public static BarGroupingKind? GetBarGrouping(BarChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BarGrouping>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BarGroupingValues, BarGroupingKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetBarGrouping(BarChart? openXmlElement, BarGroupingKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BarGrouping>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<BarGrouping, BarGroupingValues, BarGroupingKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   VaryColors.
  /// </summary>
  public static Boolean? GetVaryColors(BarChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<VaryColors>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetVaryColors(BarChart? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<VaryColors>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new VaryColors();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<BarChartSeries>? GetBarChartSerieses(BarChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<BarChartSeries>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries>())
      {
        var newItem = BarChartSeriesConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetBarChartSerieses(BarChart? openXmlElement, Collection<BarChartSeries>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = BarChartSeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DataLabels? GetDataLabels(BarChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      return DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataLabels(BarChart? openXmlElement, DataLabels? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabelsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static UInt16? GetGapWidth(BarChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<GapWidth>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetGapWidth(BarChart? openXmlElement, UInt16? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<GapWidth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new GapWidth { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SByte? GetOverlap(BarChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Overlap>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetOverlap(BarChart? openXmlElement, SByte? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Overlap>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Overlap { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<SeriesLines>? GetSeriesLineses(BarChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<SeriesLines>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.SeriesLines>())
      {
        var newItem = SeriesLinesConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetSeriesLineses(BarChart? openXmlElement, Collection<SeriesLines>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.SeriesLines>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = SeriesLinesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesLines>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static Collection<UInt32>? GetAxisIds(BarChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<UInt32>();
      foreach (var item in openXmlElement.Elements<AxisId>())
      {
        var newItem = UInt32ValueConverter.GetValue(item);
        if (newItem != null)
          collection.Add((UInt32)newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetAxisIds(BarChart? openXmlElement, Collection<UInt32>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<AxisId>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = UInt32ValueConverter.CreateOpenXmlElement<AxisId>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static BarChartExtensionList? GetBarChartExtensionList(BarChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BarChartExtensionList>();
    if (itemElement != null)
      return BarChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBarChartExtensionList(BarChart? openXmlElement, BarChartExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BarChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BarChartExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BarChartExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.BarChart? CreateModelElement(BarChart? openXmlElement)
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
    where OpenXmlElementType : BarChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBarDirection(openXmlElement, value?.BarDirection);
      SetBarGrouping(openXmlElement, value?.BarGrouping);
      SetVaryColors(openXmlElement, value?.VaryColors);
      SetBarChartSerieses(openXmlElement, value?.BarChartSerieses);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetGapWidth(openXmlElement, value?.GapWidth);
      SetOverlap(openXmlElement, value?.Overlap);
      SetSeriesLineses(openXmlElement, value?.SeriesLineses);
      SetAxisIds(openXmlElement, value?.AxisIds);
      SetBarChartExtensionList(openXmlElement, value?.BarChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}