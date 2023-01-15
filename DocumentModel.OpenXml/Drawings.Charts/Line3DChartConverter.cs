using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.Charts;
using DataLabels = DocumentModel.Drawings.Charts.DataLabels;
using DropLines = DocumentModel.Drawings.Charts.DropLines;
using Line3DChart = DocumentFormat.OpenXml.Drawing.Charts.Line3DChart;
using Line3DChartExtensionList = DocumentModel.Drawings.Charts.Line3DChartExtensionList;
using LineChartSeries = DocumentModel.Drawings.Charts.LineChartSeries;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   3D Line Charts.
/// </summary>
public static class Line3DChartConverter
{
  /// <summary>
  ///   Grouping.
  /// </summary>
  public static GroupingKind? GetGrouping(Line3DChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Grouping>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<GroupingValues, GroupingKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetGrouping(Line3DChart? openXmlElement, GroupingKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Grouping>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<Grouping, GroupingValues, GroupingKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   VaryColors.
  /// </summary>
  public static Boolean? GetVaryColors(Line3DChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<VaryColors>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetVaryColors(Line3DChart? openXmlElement, Boolean? value)
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

  public static Collection<LineChartSeries>? GetLineChartSerieses(Line3DChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<LineChartSeries>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.LineChartSeries>())
      {
        var newItem = LineChartSeriesConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetLineChartSerieses(Line3DChart? openXmlElement, Collection<LineChartSeries>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.LineChartSeries>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = LineChartSeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LineChartSeries>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DataLabels? GetDataLabels(Line3DChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      return DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataLabels(Line3DChart? openXmlElement, DataLabels? value)
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

  public static DropLines? GetDropLines(Line3DChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DropLines>();
    if (itemElement != null)
      return DropLinesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDropLines(Line3DChart? openXmlElement, DropLines? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DropLines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DropLinesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DropLines>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static UInt16? GetGapDepth(Line3DChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<GapDepth>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetGapDepth(Line3DChart? openXmlElement, UInt16? value)
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

  public static Collection<UInt32>? GetAxisIds(Line3DChart? openXmlElement)
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

  public static void SetAxisIds(Line3DChart? openXmlElement, Collection<UInt32>? value)
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

  public static Line3DChartExtensionList? GetLine3DChartExtensionList(Line3DChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtensionList>();
    if (itemElement != null)
      return Line3DChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLine3DChartExtensionList(Line3DChart? openXmlElement, Line3DChartExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Line3DChartExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.Line3DChart? CreateModelElement(Line3DChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Line3DChart();
      value.Grouping = GetGrouping(openXmlElement);
      value.VaryColors = GetVaryColors(openXmlElement);
      value.LineChartSerieses = GetLineChartSerieses(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.DropLines = GetDropLines(openXmlElement);
      value.GapDepth = GetGapDepth(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.Line3DChartExtensionList = GetLine3DChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Line3DChart? value)
    where OpenXmlElementType : Line3DChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGrouping(openXmlElement, value?.Grouping);
      SetVaryColors(openXmlElement, value?.VaryColors);
      SetLineChartSerieses(openXmlElement, value?.LineChartSerieses);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetDropLines(openXmlElement, value?.DropLines);
      SetGapDepth(openXmlElement, value?.GapDepth);
      SetAxisIds(openXmlElement, value?.AxisIds);
      SetLine3DChartExtensionList(openXmlElement, value?.Line3DChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}