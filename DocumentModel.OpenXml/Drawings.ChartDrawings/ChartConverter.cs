namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Chart Class.
/// </summary>
public static class ChartConverter
{
  /// <summary>
  /// ChartTitle.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ChartTitle? GetChartTitle(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ChartTitleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChartTitle(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart? openXmlElement, DocumentModel.Drawings.ChartDrawings.ChartTitle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.ChartTitleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// PlotArea.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.PlotArea? GetPlotArea(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.PlotAreaConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPlotArea(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart? openXmlElement, DocumentModel.Drawings.ChartDrawings.PlotArea? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.PlotAreaConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Legend.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.Legend? GetLegend(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.LegendConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLegend(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart? openXmlElement, DocumentModel.Drawings.ChartDrawings.Legend? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.LegendConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.ChartDrawings.Chart? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
