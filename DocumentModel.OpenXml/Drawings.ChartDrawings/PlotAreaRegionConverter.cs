namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the PlotAreaRegion Class.
/// </summary>
public static class PlotAreaRegionConverter
{
  /// <summary>
  /// PlotSurface.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.PlotSurface? GetPlotSurface(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotAreaRegion? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotSurface>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.PlotSurfaceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPlotSurface(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotAreaRegion? openXmlElement, DocumentModel.Drawings.ChartDrawings.PlotSurface? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotSurface>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.PlotSurfaceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotSurface>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.Series>? GetSerieses(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotAreaRegion? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.Series>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.ChartDrawings.SeriesConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetSerieses(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotAreaRegion? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.Series>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.ChartDrawings.SeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotAreaRegion? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotAreaRegion? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.PlotAreaRegion? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotAreaRegion? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotAreaRegion, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
