namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the PlotArea Class.
/// </summary>
public static class PlotAreaConverter
{
  /// <summary>
  /// PlotAreaRegion.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.PlotAreaRegion? GetPlotAreaRegion(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotAreaRegion>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.PlotAreaRegionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPlotAreaRegion(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea? openXmlElement, DocumentModel.Drawings.ChartDrawings.PlotAreaRegion? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotAreaRegion>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.PlotAreaRegionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotAreaRegion>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.Axis>? GetAxises(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.Axis>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.ChartDrawings.AxisConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetAxises(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.Axis>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.ChartDrawings.AxisConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ShapeProperties? GetShapeProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea? openXmlElement, DocumentModel.Drawings.ChartDrawings.ShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.ShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.ChartDrawings.PlotArea? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.PlotArea();
      value.PlotAreaRegion = GetPlotAreaRegion(openXmlElement);
      value.Axises = GetAxises(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.PlotArea? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
