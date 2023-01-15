using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.Charts;
using ChartShapeProperties = DocumentModel.Drawings.Charts.ChartShapeProperties;
using Layout = DocumentModel.Drawings.Charts.Layout;
using Legend = DocumentFormat.OpenXml.Drawing.Charts.Legend;
using LegendEntry = DocumentModel.Drawings.Charts.LegendEntry;
using TextProperties = DocumentModel.Drawings.Charts.TextProperties;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Legend data and formatting.
/// </summary>
public static class LegendConverter
{
  /// <summary>
  ///   Legend Position.
  /// </summary>
  public static LegendPositionKind? GetLegendPosition(Legend? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LegendPosition>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<LegendPositionValues, LegendPositionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetLegendPosition(Legend? openXmlElement, LegendPositionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LegendPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<LegendPosition, LegendPositionValues, LegendPositionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<LegendEntry>? GetLegendEntries(Legend? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<LegendEntry>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.LegendEntry>())
      {
        var newItem = LegendEntryConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetLegendEntries(Legend? openXmlElement, Collection<LegendEntry>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.LegendEntry>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = LegendEntryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LegendEntry>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static Layout? GetLayout(Legend? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Layout>();
    if (itemElement != null)
      return LayoutConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLayout(Legend? openXmlElement, Layout? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Layout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LayoutConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Layout>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetOverlay(Legend? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Overlay>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetOverlay(Legend? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Overlay>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Overlay();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ChartShapeProperties? GetChartShapeProperties(Legend? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChartShapeProperties(Legend? openXmlElement, ChartShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TextProperties? GetTextProperties(Legend? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
    if (itemElement != null)
      return TextPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextProperties(Legend? openXmlElement, TextProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(Legend? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(Legend? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
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

  public static DocumentModel.Drawings.Charts.Legend? CreateModelElement(Legend? openXmlElement)
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
    where OpenXmlElementType : Legend, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLegendPosition(openXmlElement, value?.LegendPosition);
      SetLegendEntries(openXmlElement, value?.LegendEntries);
      SetLayout(openXmlElement, value?.Layout);
      SetOverlay(openXmlElement, value?.Overlay);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetTextProperties(openXmlElement, value?.TextProperties);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}