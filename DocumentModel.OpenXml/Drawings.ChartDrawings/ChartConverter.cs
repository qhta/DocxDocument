using DocumentModel.Drawings.ChartDrawings;
using Chart = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the Chart Class.
/// </summary>
public static class ChartConverter
{
  /// <summary>
  ///   ChartTitle.
  /// </summary>
  public static ChartTitle? GetChartTitle(Chart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle>();
    if (itemElement != null)
      return ChartTitleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChartTitle(Chart? openXmlElement, ChartTitle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartTitleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   PlotArea.
  /// </summary>
  public static PlotArea? GetPlotArea(Chart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea>();
    if (itemElement != null)
      return PlotAreaConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPlotArea(Chart? openXmlElement, PlotArea? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PlotAreaConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Legend.
  /// </summary>
  public static Legend? GetLegend(Chart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend>();
    if (itemElement != null)
      return LegendConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLegend(Chart? openXmlElement, Legend? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LegendConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(Chart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(Chart? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.Chart? CreateModelElement(Chart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Chart();
      value.ChartTitle = GetChartTitle(openXmlElement);
      value.PlotArea = GetPlotArea(openXmlElement);
      value.Legend = GetLegend(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.Chart? value)
    where OpenXmlElementType : Chart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetChartTitle(openXmlElement, value?.ChartTitle);
      SetPlotArea(openXmlElement, value?.PlotArea);
      SetLegend(openXmlElement, value?.Legend);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}