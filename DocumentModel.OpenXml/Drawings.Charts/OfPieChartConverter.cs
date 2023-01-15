using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.Charts;
using CustomSplit = DocumentModel.Drawings.Charts.CustomSplit;
using DataLabels = DocumentModel.Drawings.Charts.DataLabels;
using OfPieChart = DocumentFormat.OpenXml.Drawing.Charts.OfPieChart;
using PieChartSeries = DocumentModel.Drawings.Charts.PieChartSeries;
using SeriesLines = DocumentModel.Drawings.Charts.SeriesLines;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Pie of Pie or Bar of Pie Charts.
/// </summary>
public static class OfPieChartConverter
{
  /// <summary>
  ///   Pie of Pie or Bar of Pie Type.
  /// </summary>
  public static OfPieKind? GetOfPieType(OfPieChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<OfPieType>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OfPieValues, OfPieKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetOfPieType(OfPieChart? openXmlElement, OfPieKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<OfPieType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<OfPieType, OfPieValues, OfPieKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   VaryColors.
  /// </summary>
  public static Boolean? GetVaryColors(OfPieChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<VaryColors>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetVaryColors(OfPieChart? openXmlElement, Boolean? value)
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

  public static Collection<PieChartSeries>? GetPieChartSerieses(OfPieChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<PieChartSeries>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.PieChartSeries>())
      {
        var newItem = PieChartSeriesConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetPieChartSerieses(OfPieChart? openXmlElement, Collection<PieChartSeries>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.PieChartSeries>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = PieChartSeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PieChartSeries>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DataLabels? GetDataLabels(OfPieChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      return DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataLabels(OfPieChart? openXmlElement, DataLabels? value)
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

  public static UInt16? GetGapWidth(OfPieChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<GapWidth>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetGapWidth(OfPieChart? openXmlElement, UInt16? value)
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

  public static SplitKind? GetSplitType(OfPieChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SplitType>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<SplitValues, SplitKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetSplitType(OfPieChart? openXmlElement, SplitKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SplitType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<SplitType, SplitValues, SplitKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Double? GetSplitPosition(OfPieChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SplitPosition>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSplitPosition(OfPieChart? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SplitPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new SplitPosition { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static CustomSplit? GetCustomSplit(OfPieChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CustomSplit>();
    if (itemElement != null)
      return CustomSplitConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomSplit(OfPieChart? openXmlElement, CustomSplit? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CustomSplit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CustomSplitConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.CustomSplit>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static UInt16? GetSecondPieSize(OfPieChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SecondPieSize>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSecondPieSize(OfPieChart? openXmlElement, UInt16? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SecondPieSize>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new SecondPieSize { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<SeriesLines>? GetSeriesLineses(OfPieChart? openXmlElement)
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

  public static void SetSeriesLineses(OfPieChart? openXmlElement, Collection<SeriesLines>? value)
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

  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(OfPieChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(OfPieChart? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.OfPieChart? CreateModelElement(OfPieChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.OfPieChart();
      value.OfPieType = GetOfPieType(openXmlElement);
      value.VaryColors = GetVaryColors(openXmlElement);
      value.PieChartSerieses = GetPieChartSerieses(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.GapWidth = GetGapWidth(openXmlElement);
      value.SplitType = GetSplitType(openXmlElement);
      value.SplitPosition = GetSplitPosition(openXmlElement);
      value.CustomSplit = GetCustomSplit(openXmlElement);
      value.SecondPieSize = GetSecondPieSize(openXmlElement);
      value.SeriesLineses = GetSeriesLineses(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.OfPieChart? value)
    where OpenXmlElementType : OfPieChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetOfPieType(openXmlElement, value?.OfPieType);
      SetVaryColors(openXmlElement, value?.VaryColors);
      SetPieChartSerieses(openXmlElement, value?.PieChartSerieses);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetGapWidth(openXmlElement, value?.GapWidth);
      SetSplitType(openXmlElement, value?.SplitType);
      SetSplitPosition(openXmlElement, value?.SplitPosition);
      SetCustomSplit(openXmlElement, value?.CustomSplit);
      SetSecondPieSize(openXmlElement, value?.SecondPieSize);
      SetSeriesLineses(openXmlElement, value?.SeriesLineses);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}