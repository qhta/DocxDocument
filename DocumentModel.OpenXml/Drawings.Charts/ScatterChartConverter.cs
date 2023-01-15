using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.Charts;
using DataLabels = DocumentModel.Drawings.Charts.DataLabels;
using ScatterChart = DocumentFormat.OpenXml.Drawing.Charts.ScatterChart;
using ScatterChartExtensionList = DocumentModel.Drawings.Charts.ScatterChartExtensionList;
using ScatterChartSeries = DocumentModel.Drawings.Charts.ScatterChartSeries;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Scatter Charts.
/// </summary>
public static class ScatterChartConverter
{
  /// <summary>
  ///   ScatterStyle.
  /// </summary>
  public static ScatterStyleKind? GetScatterStyle(ScatterChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ScatterStyle>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<ScatterStyleValues, ScatterStyleKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetScatterStyle(ScatterChart? openXmlElement, ScatterStyleKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ScatterStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<ScatterStyle, ScatterStyleValues, ScatterStyleKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   VaryColors.
  /// </summary>
  public static Boolean? GetVaryColors(ScatterChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<VaryColors>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetVaryColors(ScatterChart? openXmlElement, Boolean? value)
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

  public static Collection<ScatterChartSeries>? GetScatterChartSerieses(ScatterChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ScatterChartSeries>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries>())
      {
        var newItem = ScatterChartSeriesConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetScatterChartSerieses(ScatterChart? openXmlElement, Collection<ScatterChartSeries>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ScatterChartSeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DataLabels? GetDataLabels(ScatterChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      return DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataLabels(ScatterChart? openXmlElement, DataLabels? value)
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

  public static Collection<UInt32>? GetAxisIds(ScatterChart? openXmlElement)
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

  public static void SetAxisIds(ScatterChart? openXmlElement, Collection<UInt32>? value)
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

  public static ScatterChartExtensionList? GetScatterChartExtensionList(ScatterChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtensionList>();
    if (itemElement != null)
      return ScatterChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetScatterChartExtensionList(ScatterChart? openXmlElement, ScatterChartExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ScatterChartExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.ScatterChart? CreateModelElement(ScatterChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ScatterChart();
      value.ScatterStyle = GetScatterStyle(openXmlElement);
      value.VaryColors = GetVaryColors(openXmlElement);
      value.ScatterChartSerieses = GetScatterChartSerieses(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.ScatterChartExtensionList = GetScatterChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ScatterChart? value)
    where OpenXmlElementType : ScatterChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetScatterStyle(openXmlElement, value?.ScatterStyle);
      SetVaryColors(openXmlElement, value?.VaryColors);
      SetScatterChartSerieses(openXmlElement, value?.ScatterChartSerieses);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetAxisIds(openXmlElement, value?.AxisIds);
      SetScatterChartExtensionList(openXmlElement, value?.ScatterChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}