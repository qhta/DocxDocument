using DocumentFormat.OpenXml.Drawing.Charts;
using HeaderFooter = DocumentModel.Drawings.Charts.HeaderFooter;
using PageMargins = DocumentModel.Drawings.Charts.PageMargins;
using PageSetup = DocumentModel.Drawings.Charts.PageSetup;
using PrintSettings = DocumentFormat.OpenXml.Drawing.Charts.PrintSettings;
using RelationshipIdType = DocumentModel.Drawings.Charts.RelationshipIdType;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the PrintSettings Class.
/// </summary>
public static class PrintSettingsConverter
{
  /// <summary>
  ///   Header and Footer.
  /// </summary>
  public static HeaderFooter? GetHeaderFooter(PrintSettings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter>();
    if (itemElement != null)
      return HeaderFooterConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHeaderFooter(PrintSettings? openXmlElement, HeaderFooter? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HeaderFooterConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Page Margins.
  /// </summary>
  public static PageMargins? GetPageMargins(PrintSettings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PageMargins>();
    if (itemElement != null)
      return PageMarginsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPageMargins(PrintSettings? openXmlElement, PageMargins? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PageMargins>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PageMarginsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PageMargins>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Page Setup.
  /// </summary>
  public static PageSetup? GetPageSetup(PrintSettings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PageSetup>();
    if (itemElement != null)
      return PageSetupConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPageSetup(PrintSettings? openXmlElement, PageSetup? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PageSetup>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PageSetupConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PageSetup>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Legacy Drawing for Headers and Footers.
  /// </summary>
  public static RelationshipIdType? GetLegacyDrawingHeaderFooter(PrintSettings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LegacyDrawingHeaderFooter>();
    if (itemElement != null)
      return RelationshipIdTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLegacyDrawingHeaderFooter(PrintSettings? openXmlElement, RelationshipIdType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LegacyDrawingHeaderFooter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RelationshipIdTypeConverter.CreateOpenXmlElement<LegacyDrawingHeaderFooter>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.PrintSettings? CreateModelElement(PrintSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PrintSettings();
      value.HeaderFooter = GetHeaderFooter(openXmlElement);
      value.PageMargins = GetPageMargins(openXmlElement);
      value.PageSetup = GetPageSetup(openXmlElement);
      value.LegacyDrawingHeaderFooter = GetLegacyDrawingHeaderFooter(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.PrintSettings? value)
    where OpenXmlElementType : PrintSettings, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetHeaderFooter(openXmlElement, value?.HeaderFooter);
      SetPageMargins(openXmlElement, value?.PageMargins);
      SetPageSetup(openXmlElement, value?.PageSetup);
      SetLegacyDrawingHeaderFooter(openXmlElement, value?.LegacyDrawingHeaderFooter);
      return openXmlElement;
    }
    return default;
  }
}