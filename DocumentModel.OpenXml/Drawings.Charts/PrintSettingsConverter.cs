namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PrintSettings Class.
/// </summary>
public static class PrintSettingsConverter
{
  /// <summary>
  /// Header and Footer.
  /// </summary>
  private static DMDrawsCharts.HeaderFooter? GetHeaderFooter(DXDrawCharts.PrintSettings openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.HeaderFooter>();
    if (itemElement != null)
      return DMXDrawsCharts.HeaderFooterConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHeaderFooter(DXDrawCharts.PrintSettings openXmlElement, DMDrawsCharts.HeaderFooter? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.HeaderFooter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.HeaderFooterConverter.CreateOpenXmlElement<DXDrawCharts.HeaderFooter>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Page Margins.
  /// </summary>
  private static DMDrawsCharts.PageMargins? GetPageMargins(DXDrawCharts.PrintSettings openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.PageMargins>();
    if (itemElement != null)
      return DMXDrawsCharts.PageMarginsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPageMargins(DXDrawCharts.PrintSettings openXmlElement, DMDrawsCharts.PageMargins? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.PageMargins>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.PageMarginsConverter.CreateOpenXmlElement<DXDrawCharts.PageMargins>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Page Setup.
  /// </summary>
  private static DMDrawsCharts.PageSetup? GetPageSetup(DXDrawCharts.PrintSettings openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.PageSetup>();
    if (itemElement != null)
      return DMXDrawsCharts.PageSetupConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPageSetup(DXDrawCharts.PrintSettings openXmlElement, DMDrawsCharts.PageSetup? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.PageSetup>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.PageSetupConverter.CreateOpenXmlElement<DXDrawCharts.PageSetup>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Legacy Drawing for Headers and Footers.
  /// </summary>
  private static DMDrawsCharts.RelationshipIdType? GetLegacyDrawingHeaderFooter(DXDrawCharts.PrintSettings openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.LegacyDrawingHeaderFooter>();
    if (itemElement != null)
      return DMXDrawsCharts.RelationshipIdTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLegacyDrawingHeaderFooter(DXDrawCharts.PrintSettings openXmlElement, DMDrawsCharts.RelationshipIdType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.LegacyDrawingHeaderFooter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.RelationshipIdTypeConverter.CreateOpenXmlElement<DXDrawCharts.LegacyDrawingHeaderFooter>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.PrintSettings? CreateModelElement(DXDrawCharts.PrintSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.PrintSettings();
      value.HeaderFooter = GetHeaderFooter(openXmlElement);
      value.PageMargins = GetPageMargins(openXmlElement);
      value.PageSetup = GetPageSetup(openXmlElement);
      value.LegacyDrawingHeaderFooter = GetLegacyDrawingHeaderFooter(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.PrintSettings? value)
    where OpenXmlElementType: DXDrawCharts.PrintSettings, new()
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
