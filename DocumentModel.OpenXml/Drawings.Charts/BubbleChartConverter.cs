using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.Charts;
using BubbleChart = DocumentFormat.OpenXml.Drawing.Charts.BubbleChart;
using BubbleChartExtensionList = DocumentModel.Drawings.Charts.BubbleChartExtensionList;
using BubbleChartSeries = DocumentModel.Drawings.Charts.BubbleChartSeries;
using DataLabels = DocumentModel.Drawings.Charts.DataLabels;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Bubble Charts.
/// </summary>
public static class BubbleChartConverter
{
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public static Boolean? GetVaryColors(BubbleChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<VaryColors>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetVaryColors(BubbleChart? openXmlElement, Boolean? value)
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

  public static Collection<BubbleChartSeries>? GetBubbleChartSerieses(BubbleChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<BubbleChartSeries>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.BubbleChartSeries>())
      {
        var newItem = BubbleChartSeriesConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetBubbleChartSerieses(BubbleChart? openXmlElement, Collection<BubbleChartSeries>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.BubbleChartSeries>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = BubbleChartSeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BubbleChartSeries>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DataLabels? GetDataLabels(BubbleChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      return DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataLabels(BubbleChart? openXmlElement, DataLabels? value)
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

  public static Boolean? GetBubble3D(BubbleChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Bubble3D>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBubble3D(BubbleChart? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Bubble3D>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Bubble3D();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static UInt32? GetBubbleScale(BubbleChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BubbleScale>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetBubbleScale(BubbleChart? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BubbleScale>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new BubbleScale { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetShowNegativeBubbles(BubbleChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShowNegativeBubbles>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShowNegativeBubbles(BubbleChart? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ShowNegativeBubbles>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ShowNegativeBubbles();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SizeRepresentsKind? GetSizeRepresents(BubbleChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SizeRepresents>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<SizeRepresentsValues, SizeRepresentsKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetSizeRepresents(BubbleChart? openXmlElement, SizeRepresentsKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SizeRepresents>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<SizeRepresents, SizeRepresentsValues, SizeRepresentsKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<UInt32>? GetAxisIds(BubbleChart? openXmlElement)
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

  public static void SetAxisIds(BubbleChart? openXmlElement, Collection<UInt32>? value)
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

  public static BubbleChartExtensionList? GetBubbleChartExtensionList(BubbleChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtensionList>();
    if (itemElement != null)
      return BubbleChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBubbleChartExtensionList(BubbleChart? openXmlElement, BubbleChartExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BubbleChartExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.BubbleChart? CreateModelElement(BubbleChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BubbleChart();
      value.VaryColors = GetVaryColors(openXmlElement);
      value.BubbleChartSerieses = GetBubbleChartSerieses(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.Bubble3D = GetBubble3D(openXmlElement);
      value.BubbleScale = GetBubbleScale(openXmlElement);
      value.ShowNegativeBubbles = GetShowNegativeBubbles(openXmlElement);
      value.SizeRepresents = GetSizeRepresents(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.BubbleChartExtensionList = GetBubbleChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.BubbleChart? value)
    where OpenXmlElementType : BubbleChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVaryColors(openXmlElement, value?.VaryColors);
      SetBubbleChartSerieses(openXmlElement, value?.BubbleChartSerieses);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetBubble3D(openXmlElement, value?.Bubble3D);
      SetBubbleScale(openXmlElement, value?.BubbleScale);
      SetShowNegativeBubbles(openXmlElement, value?.ShowNegativeBubbles);
      SetSizeRepresents(openXmlElement, value?.SizeRepresents);
      SetAxisIds(openXmlElement, value?.AxisIds);
      SetBubbleChartExtensionList(openXmlElement, value?.BubbleChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}