using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.Charts;
using Bar3DChart = DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart;
using Bar3DChartExtensionList = DocumentModel.Drawings.Charts.Bar3DChartExtensionList;
using BarChartSeries = DocumentModel.Drawings.Charts.BarChartSeries;
using DataLabels = DocumentModel.Drawings.Charts.DataLabels;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   3D Bar Charts.
/// </summary>
public static class Bar3DChartConverter
{
  /// <summary>
  ///   Bar Direction.
  /// </summary>
  public static BarDirectionKind? GetBarDirection(Bar3DChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BarDirection>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BarDirectionValues, BarDirectionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetBarDirection(Bar3DChart? openXmlElement, BarDirectionKind? value)
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
  public static BarGroupingKind? GetBarGrouping(Bar3DChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BarGrouping>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BarGroupingValues, BarGroupingKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetBarGrouping(Bar3DChart? openXmlElement, BarGroupingKind? value)
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
  public static Boolean? GetVaryColors(Bar3DChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<VaryColors>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetVaryColors(Bar3DChart? openXmlElement, Boolean? value)
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

  public static Collection<BarChartSeries>? GetBarChartSerieses(Bar3DChart? openXmlElement)
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

  public static void SetBarChartSerieses(Bar3DChart? openXmlElement, Collection<BarChartSeries>? value)
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

  public static DataLabels? GetDataLabels(Bar3DChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      return DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataLabels(Bar3DChart? openXmlElement, DataLabels? value)
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

  public static UInt16? GetGapWidth(Bar3DChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<GapWidth>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetGapWidth(Bar3DChart? openXmlElement, UInt16? value)
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

  public static UInt16? GetGapDepth(Bar3DChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<GapDepth>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetGapDepth(Bar3DChart? openXmlElement, UInt16? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<GapDepth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new GapDepth { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ShapeKind? GetShape(Bar3DChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Shape>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<ShapeValues, ShapeKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetShape(Bar3DChart? openXmlElement, ShapeKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Shape>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<Shape, ShapeValues, ShapeKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<UInt32>? GetAxisIds(Bar3DChart? openXmlElement)
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

  public static void SetAxisIds(Bar3DChart? openXmlElement, Collection<UInt32>? value)
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

  public static Bar3DChartExtensionList? GetBar3DChartExtensionList(Bar3DChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtensionList>();
    if (itemElement != null)
      return Bar3DChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBar3DChartExtensionList(Bar3DChart? openXmlElement, Bar3DChartExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Bar3DChartExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.Bar3DChart? CreateModelElement(Bar3DChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Bar3DChart();
      value.BarDirection = GetBarDirection(openXmlElement);
      value.BarGrouping = GetBarGrouping(openXmlElement);
      value.VaryColors = GetVaryColors(openXmlElement);
      value.BarChartSerieses = GetBarChartSerieses(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.GapWidth = GetGapWidth(openXmlElement);
      value.GapDepth = GetGapDepth(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.Bar3DChartExtensionList = GetBar3DChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Bar3DChart? value)
    where OpenXmlElementType : Bar3DChart, new()
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
      SetGapDepth(openXmlElement, value?.GapDepth);
      SetShape(openXmlElement, value?.Shape);
      SetAxisIds(openXmlElement, value?.AxisIds);
      SetBar3DChartExtensionList(openXmlElement, value?.Bar3DChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}