namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PrintSettings Class.
/// </summary>
public static class PrintSettingsConverter
{
  /// <summary>
  /// Header and Footer.
  /// </summary>
  public static DocumentModel.Drawings.Charts.HeaderFooter? GetHeaderFooter(DocumentFormat.OpenXml.Drawing.Charts.PrintSettings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.HeaderFooterConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetHeaderFooter(DocumentFormat.OpenXml.Drawing.Charts.PrintSettings? openXmlElement, DocumentModel.Drawings.Charts.HeaderFooter? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.HeaderFooterConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Page Margins.
  /// </summary>
  public static DocumentModel.Drawings.Charts.PageMargins? GetPageMargins(DocumentFormat.OpenXml.Drawing.Charts.PrintSettings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PageMargins>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.PageMarginsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPageMargins(DocumentFormat.OpenXml.Drawing.Charts.PrintSettings? openXmlElement, DocumentModel.Drawings.Charts.PageMargins? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PageMargins>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.PageMarginsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PageMargins>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Page Setup.
  /// </summary>
  public static DocumentModel.Drawings.Charts.PageSetup? GetPageSetup(DocumentFormat.OpenXml.Drawing.Charts.PrintSettings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PageSetup>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.PageSetupConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPageSetup(DocumentFormat.OpenXml.Drawing.Charts.PrintSettings? openXmlElement, DocumentModel.Drawings.Charts.PageSetup? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PageSetup>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.PageSetupConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PageSetup>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Legacy Drawing for Headers and Footers.
  /// </summary>
  public static DocumentModel.Drawings.Charts.RelationshipIdType? GetLegacyDrawingHeaderFooter(DocumentFormat.OpenXml.Drawing.Charts.PrintSettings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LegacyDrawingHeaderFooter>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.RelationshipIdTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLegacyDrawingHeaderFooter(DocumentFormat.OpenXml.Drawing.Charts.PrintSettings? openXmlElement, DocumentModel.Drawings.Charts.RelationshipIdType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LegacyDrawingHeaderFooter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.RelationshipIdTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LegacyDrawingHeaderFooter>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.PrintSettings? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.PrintSettings? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.PrintSettings, new()
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
