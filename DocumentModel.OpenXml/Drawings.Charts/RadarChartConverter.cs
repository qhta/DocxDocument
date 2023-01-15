using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.Charts;
using DataLabels = DocumentModel.Drawings.Charts.DataLabels;
using RadarChart = DocumentFormat.OpenXml.Drawing.Charts.RadarChart;
using RadarChartExtensionList = DocumentModel.Drawings.Charts.RadarChartExtensionList;
using RadarChartSeries = DocumentModel.Drawings.Charts.RadarChartSeries;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Radar Charts.
/// </summary>
public static class RadarChartConverter
{
  /// <summary>
  ///   RadarStyle.
  /// </summary>
  public static RadarStyleKind? GetRadarStyle(RadarChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RadarStyle>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<RadarStyleValues, RadarStyleKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetRadarStyle(RadarChart? openXmlElement, RadarStyleKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RadarStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<RadarStyle, RadarStyleValues, RadarStyleKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   VaryColors.
  /// </summary>
  public static Boolean? GetVaryColors(RadarChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<VaryColors>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetVaryColors(RadarChart? openXmlElement, Boolean? value)
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

  public static Collection<RadarChartSeries>? GetRadarChartSerieses(RadarChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<RadarChartSeries>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.RadarChartSeries>())
      {
        var newItem = RadarChartSeriesConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetRadarChartSerieses(RadarChart? openXmlElement, Collection<RadarChartSeries>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.RadarChartSeries>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = RadarChartSeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.RadarChartSeries>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DataLabels? GetDataLabels(RadarChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      return DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataLabels(RadarChart? openXmlElement, DataLabels? value)
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

  public static Collection<UInt32>? GetAxisIds(RadarChart? openXmlElement)
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

  public static void SetAxisIds(RadarChart? openXmlElement, Collection<UInt32>? value)
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

  public static RadarChartExtensionList? GetRadarChartExtensionList(RadarChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtensionList>();
    if (itemElement != null)
      return RadarChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRadarChartExtensionList(RadarChart? openXmlElement, RadarChartExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RadarChartExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.RadarChart? CreateModelElement(RadarChart? openXmlElement)
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
    where OpenXmlElementType : RadarChart, new()
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