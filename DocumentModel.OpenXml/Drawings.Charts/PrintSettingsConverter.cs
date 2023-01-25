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
    return DMXDrawsCharts.HeaderFooterConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.HeaderFooter>());
  }
  
  private static bool CmpHeaderFooter(DXDrawCharts.PrintSettings openXmlElement, DMDrawsCharts.HeaderFooter? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.HeaderFooterConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.HeaderFooter>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.PageMarginsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.PageMargins>());
  }
  
  private static bool CmpPageMargins(DXDrawCharts.PrintSettings openXmlElement, DMDrawsCharts.PageMargins? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.PageMarginsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.PageMargins>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.PageSetupConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.PageSetup>());
  }
  
  private static bool CmpPageSetup(DXDrawCharts.PrintSettings openXmlElement, DMDrawsCharts.PageSetup? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.PageSetupConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.PageSetup>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.RelationshipIdTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.LegacyDrawingHeaderFooter>());
  }
  
  private static bool CmpLegacyDrawingHeaderFooter(DXDrawCharts.PrintSettings openXmlElement, DMDrawsCharts.RelationshipIdType? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.RelationshipIdTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.LegacyDrawingHeaderFooter>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXDrawCharts.PrintSettings? openXmlElement, DMDrawsCharts.PrintSettings? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpHeaderFooter(openXmlElement, value.HeaderFooter, diffs, objName))
        ok = false;
      if (!CmpPageMargins(openXmlElement, value.PageMargins, diffs, objName))
        ok = false;
      if (!CmpPageSetup(openXmlElement, value.PageSetup, diffs, objName))
        ok = false;
      if (!CmpLegacyDrawingHeaderFooter(openXmlElement, value.LegacyDrawingHeaderFooter, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
