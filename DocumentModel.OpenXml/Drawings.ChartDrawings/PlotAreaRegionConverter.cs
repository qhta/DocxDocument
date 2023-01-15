using DocumentModel.Drawings.ChartDrawings;
using PlotAreaRegion = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotAreaRegion;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the PlotAreaRegion Class.
/// </summary>
public static class PlotAreaRegionConverter
{
  /// <summary>
  ///   PlotSurface.
  /// </summary>
  public static PlotSurface? GetPlotSurface(PlotAreaRegion? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotSurface>();
    if (itemElement != null)
      return PlotSurfaceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPlotSurface(PlotAreaRegion? openXmlElement, PlotSurface? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotSurface>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PlotSurfaceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotSurface>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<Series>? GetSerieses(PlotAreaRegion? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Series>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series>())
      {
        var newItem = SeriesConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetSerieses(PlotAreaRegion? openXmlElement, Collection<Series>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = SeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(PlotAreaRegion? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(PlotAreaRegion? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
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

  public static DocumentModel.Drawings.ChartDrawings.PlotAreaRegion? CreateModelElement(PlotAreaRegion? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.PlotAreaRegion();
      value.PlotSurface = GetPlotSurface(openXmlElement);
      value.Serieses = GetSerieses(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.PlotAreaRegion? value)
    where OpenXmlElementType : PlotAreaRegion, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPlotSurface(openXmlElement, value?.PlotSurface);
      SetSerieses(openXmlElement, value?.Serieses);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}