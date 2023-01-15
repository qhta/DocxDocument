using DocumentFormat.OpenXml.Office2013.Drawing.Chart;
using DocumentModel.Drawings.Charts;
using ChartText = DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText;
using DataLabelFieldTable = DocumentModel.Drawings.Charts.DataLabelFieldTable;
using DLblsExtension = DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension;
using Layout = DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout;
using LeaderLines = DocumentFormat.OpenXml.Office2013.Drawing.Chart.LeaderLines;
using ShapeProperties = DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the DLblsExtension Class.
/// </summary>
public static class DLblsExtensionConverter
{
  /// <summary>
  ///   URI
  /// </summary>
  public static String? GetUri(DLblsExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(DLblsExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  public static ChartText3? GetChartText(DLblsExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ChartText>();
    if (itemElement != null)
      return ChartText3Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChartText(DLblsExtension? openXmlElement, ChartText3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ChartText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartText3Converter.CreateOpenXmlElement<ChartText>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DataLabelFieldTable? GetDataLabelFieldTable(DLblsExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable>();
    if (itemElement != null)
      return DataLabelFieldTableConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataLabelFieldTable(DLblsExtension? openXmlElement, DataLabelFieldTable? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabelFieldTableConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetShowDataLabelsRange(DLblsExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShowDataLabelsRange>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShowDataLabelsRange(DLblsExtension? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ShowDataLabelsRange>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ShowDataLabelsRange();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ShapeProperties3? GetShapeProperties(DLblsExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ShapeProperties>();
    if (itemElement != null)
      return ShapeProperties3Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeProperties(DLblsExtension? openXmlElement, ShapeProperties3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeProperties3Converter.CreateOpenXmlElement<ShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Layout3? GetLayout(DLblsExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Layout>();
    if (itemElement != null)
      return Layout3Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLayout(DLblsExtension? openXmlElement, Layout3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Layout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Layout3Converter.CreateOpenXmlElement<Layout>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetShowLeaderLines(DLblsExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShowLeaderLines>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShowLeaderLines(DLblsExtension? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ShowLeaderLines>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ShowLeaderLines();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LeaderLines3? GetLeaderLines(DLblsExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LeaderLines>();
    if (itemElement != null)
      return LeaderLines3Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLeaderLines(DLblsExtension? openXmlElement, LeaderLines3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LeaderLines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LeaderLines3Converter.CreateOpenXmlElement<LeaderLines>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.DLblsExtension? CreateModelElement(DLblsExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DLblsExtension();
      value.Uri = GetUri(openXmlElement);
      value.ChartText = GetChartText(openXmlElement);
      value.DataLabelFieldTable = GetDataLabelFieldTable(openXmlElement);
      value.ShowDataLabelsRange = GetShowDataLabelsRange(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.Layout = GetLayout(openXmlElement);
      value.ShowLeaderLines = GetShowLeaderLines(openXmlElement);
      value.LeaderLines = GetLeaderLines(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.DLblsExtension? value)
    where OpenXmlElementType : DLblsExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetChartText(openXmlElement, value?.ChartText);
      SetDataLabelFieldTable(openXmlElement, value?.DataLabelFieldTable);
      SetShowDataLabelsRange(openXmlElement, value?.ShowDataLabelsRange);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetLayout(openXmlElement, value?.Layout);
      SetShowLeaderLines(openXmlElement, value?.ShowLeaderLines);
      SetLeaderLines(openXmlElement, value?.LeaderLines);
      return openXmlElement;
    }
    return default;
  }
}