using DocumentModel.Drawings.ChartDrawings;
using PrintSettings = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the PrintSettings Class.
/// </summary>
public static class PrintSettingsConverter
{
  /// <summary>
  ///   HeaderFooter.
  /// </summary>
  public static HeaderFooter? GetHeaderFooter(PrintSettings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter>();
    if (itemElement != null)
      return HeaderFooterConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHeaderFooter(PrintSettings? openXmlElement, HeaderFooter? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HeaderFooterConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   PageMargins.
  /// </summary>
  public static PageMargins? GetPageMargins(PrintSettings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins>();
    if (itemElement != null)
      return PageMarginsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPageMargins(PrintSettings? openXmlElement, PageMargins? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PageMarginsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   PageSetup.
  /// </summary>
  public static PageSetup? GetPageSetup(PrintSettings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup>();
    if (itemElement != null)
      return PageSetupConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPageSetup(PrintSettings? openXmlElement, PageSetup? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PageSetupConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.PrintSettings? CreateModelElement(PrintSettings? openXmlElement)
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
    where OpenXmlElementType : PrintSettings, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetHeaderFooter(openXmlElement, value?.HeaderFooter);
      SetPageMargins(openXmlElement, value?.PageMargins);
      SetPageSetup(openXmlElement, value?.PageSetup);
      return openXmlElement;
    }
    return default;
  }
}