namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the PrintSettings Class.
/// </summary>
public static class PrintSettingsConverter
{
  /// <summary>
  /// HeaderFooter.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.HeaderFooter? GetHeaderFooter(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.HeaderFooterConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetHeaderFooter(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings? openXmlElement, DocumentModel.Drawings.ChartDrawings.HeaderFooter? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.HeaderFooterConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// PageMargins.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.PageMargins? GetPageMargins(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.PageMarginsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPageMargins(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings? openXmlElement, DocumentModel.Drawings.ChartDrawings.PageMargins? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.PageMarginsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// PageSetup.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.PageSetup? GetPageSetup(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.PageSetupConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPageSetup(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings? openXmlElement, DocumentModel.Drawings.ChartDrawings.PageSetup? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.PageSetupConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.PrintSettings? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.PrintSettings();
      value.HeaderFooter = GetHeaderFooter(openXmlElement);
      value.PageMargins = GetPageMargins(openXmlElement);
      value.PageSetup = GetPageSetup(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.PrintSettings? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
